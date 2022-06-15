using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText;
    public int showScore = 0;

    private void Start()
    {
        showScore = ScoreController.newscore;
        scoreText.text = "Score: " + showScore.ToString();
    }

    private void Update()
    {
        scoreText.text = "Score: " + showScore.ToString();
    }
}
