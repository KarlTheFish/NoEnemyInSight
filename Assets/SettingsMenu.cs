using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {   
            GameObject settingss = new GameObject();
            print("space key was pressed");
            GameObject.SetActive(false);
        }      
    }
}
