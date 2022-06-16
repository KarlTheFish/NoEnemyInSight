using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public Text scoreText;
    public int showScore = 0;

    private void Update()
    {
        showScore = ScoreController.levelScore;
        scoreText.text = "Score: " + showScore.ToString();
    }
}
