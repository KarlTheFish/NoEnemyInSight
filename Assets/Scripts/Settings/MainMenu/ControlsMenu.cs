using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlsMenu : MonoBehaviour
{
    public Button keys;
    public Button mouse;
    public string controls;
    public Slider mouseSlider;
    public Slider keysSlider;

    void Start()
    {
        changeKeysSens();
        changeMouseSens();
    }

    /*
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
    */

    public void changeMouseSens()
    {
        Debug.Log(mouseSlider.value);
        SensitivityController.mouseSensitivity = mouseSlider.value;
        Debug.Log("value:" + SensitivityController.mouseSensitivity);
    }

    public void changeKeysSens()
    {
        Debug.Log(keysSlider.value);
        SensitivityController.keysSensitivity = keysSlider.value;
    }
}
