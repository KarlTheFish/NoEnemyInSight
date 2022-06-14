using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
        Time.timeScale = 1f;
        //SceneManager.LoadScene("WeaponMenu"); THIS WILL BE ADDED BACK ONCE IT IS NOT FUCKING BROKEN ANYMORE
        SceneManager.LoadScene("gameplayLvl0");
    }

    public void QuitGame() {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
