using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public Button nextLevel;

    public void PlayGame()
    {
        SceneManager.LoadScene(Levels.levelNumber);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(Levels.nextLevel);
    }

    public void Restart()
    {
        Levels.nextLevel = 1;
        Levels.levelNumber = 1;
        Levels.lastScreen = 0;
        SceneManager.LoadScene(1);
    }
}
