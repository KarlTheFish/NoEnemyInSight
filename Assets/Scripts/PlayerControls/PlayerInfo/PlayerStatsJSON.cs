using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStatsJSON
{
    public int score;
    public int playerHealth;

    public PlayerStatsJSON(PlayerStats playerStats)
    {
        score = playerStats.score;
        playerHealth = playerStats.playerHealth;
    }
}
