using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowMainScore : MonoBehaviour
{
    public TMP_Text mainScore;
    public int showMainScore = 0;

    private void Start()
    {
        LoadStats();
    }

    private void Update()
    {
        mainScore.text = "Score: " + showMainScore.ToString();
    }

    public void LoadStats()
    {
        PlayerStatsJSON data = SaveSystem.LoadStats();

        showMainScore = data.score;
    }
}
