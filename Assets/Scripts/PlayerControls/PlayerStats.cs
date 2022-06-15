using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int score;
    public int playerHealth;
    public int secretHealth;

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
    }

    public void AddScore()
    {
        ScoreController.newscore = score;
    }
}
