using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    private bool _gameIsPaused;

    private void Awake()
    {
        pauseMenu = GameObject.Find("Canvas");
        _gameIsPaused = GameObject.Find("Level").GetComponent<PauseGame>().gameIsPaused;
    }
    public void ResumeGame()
    {
        _gameIsPaused = !_gameIsPaused;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        AudioListener.pause = false;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        ResumeGame();
    }
}
