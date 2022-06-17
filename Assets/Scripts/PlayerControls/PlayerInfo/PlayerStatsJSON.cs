using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStatsJSON
{
    public int score;

    public PlayerStatsJSON(PlayerStats playerStats)
    {
        score = playerStats.score;
    }
}
