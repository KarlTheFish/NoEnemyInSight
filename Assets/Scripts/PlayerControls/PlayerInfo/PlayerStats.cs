using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Levels levels;

    public int score;
    public int playerHealth;
    public int secretHealth;
    public int levelScore;

    public void SaveStats()
    {
        SaveSystem.SaveStats(this);
    }

    public void LoadStats()
    {
        PlayerStatsJSON data = SaveSystem.LoadStats();

        score = data.score;
        playerHealth = data.playerHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveStats();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadStats();
        }
        if (levels.level1 == 0 || playerHealth == 0)
        {
            AddScore();
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
