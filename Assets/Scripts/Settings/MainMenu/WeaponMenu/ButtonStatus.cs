using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonStatus : MonoBehaviour
{
    public ShowMainScore score;

    public Button rifleButton;
    public Button shotgunButton;

    private void Update()
    {
        if (score.showMainScore < 30)
        {
            rifleButton.interactable = false;
        }
        if (score.showMainScore < 100)
        {
            shotgunButton.interactable = false;
        }
    }
}
