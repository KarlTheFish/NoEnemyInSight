using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;
// using UnityEngine.Localization;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public void SetSelectedLocale(int index)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
    
    /* 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SetSelectedLocale(0); // set to eng
        }    
        if (Input.GetKeyDown(KeyCode.F))
        {
            SetSelectedLocale(1); // set to est
        }  
    }
    */
    
    public void SetEnglish(){
        SetSelectedLocale(0);
    }

    public void SetEstonian(){
        SetSelectedLocale(1);
    }
}
