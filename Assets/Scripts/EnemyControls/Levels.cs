using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public PlayerStats playerStats;

    public int level1;
    public static int levelNumber = 1;
    public static int nextLevel = 1;
    public static int lastScreen = 0;

    private void Update()
    {
        if (playerStats.playerHealth == 0)
        {
            SceneManager.LoadScene(4);
        }
        if (level1 == 0)
        {
            SceneManager.LoadScene(5);
            if (lastScreen == 2)
            {
                SceneManager.LoadScene(6);
            }
        }
        Debug.Log(lastScreen);
    }
}
