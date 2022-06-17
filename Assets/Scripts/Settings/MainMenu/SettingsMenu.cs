using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Localization.Settings;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public void SetSelectedLocale(int index)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
    
    public void SetEnglish(){
        SetSelectedLocale(0);
    }

    public void SetEstonian(){
        SetSelectedLocale(1);
    }
}
