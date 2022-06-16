using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    // Start is called before the first frame update
    float aimSpeed = 5f;
    void Start()
    {
        if (SensitivityController.mouseSensitivity != 0)
        {
            aimSpeed = SensitivityController.mouseSensitivity;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseGame.gameIsPaused)
        {
            float aiming = aimSpeed * Input.GetAxis("Mouse X");

            transform.Rotate(0, aiming, 0);
        }
    }
}
