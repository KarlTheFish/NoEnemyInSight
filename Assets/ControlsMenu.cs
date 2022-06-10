using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public Button keys;
    public Button mouse;
    public string controls;

    public void CheckControls()
    {
        if (keys.interactable == false) 
        {
            Debug.Log("Keys is not interactable");
            controls = "keys";
        }
        if (mouse.interactable == false) 
        {
            Debug.Log("Mouse is not interactable");
            controls = "mouse";
        }
    }
 
}
