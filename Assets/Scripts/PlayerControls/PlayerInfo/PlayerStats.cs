using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Levels levels;

    public int score;
    public int playerHealth = 3;
    public int secretHealth = 1;
    public int levelScore;

    public void SaveStats()
    {
        SaveSystem.SaveStats(this);
    }

    public void LoadStats()
    {
        PlayerStatsJSON data = SaveSystem.LoadStats();

        score = data.score;
    }

    void Update()
    {
        if (levels.level1 == 0 || playerHealth == 0)
        {
            AddScore();
            SaveStats();
        }
        if (levels.level1 == 0)
        {
            Levels.levelNumber++;
            Levels.nextLevel++;
            Levels.lastScreen++;
            if (Levels.levelNumber >= 3)
            {
                Levels.levelNumber = 3;
            }
            if (Levels.nextLevel >= 3)
            {
                Levels.nextLevel = 3;
            }
        }
    }

    private void Start()
    {
        LoadStats();
    }

    public void AddScore()
    {
        ScoreController.levelScore = levelScore;
    }
}
