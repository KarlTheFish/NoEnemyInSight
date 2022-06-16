using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject pauseMenu;

    private void Awake()
    {
        pauseMenu = GameObject.Find("Canvas");
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            Pause();
        }
    }
    public void Pause()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            AudioListener.pause = true;
        }
        else
        {
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
            AudioListener.pause = false;
        }
    }

    private void Start()
    {
        pauseMenu.SetActive(false);
    }
}
