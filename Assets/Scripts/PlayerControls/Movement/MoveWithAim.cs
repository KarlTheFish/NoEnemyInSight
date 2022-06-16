using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithAim : MonoBehaviour
{
    public ControlsMenu controlsMenu;

    public float aimSpeed = 5.0f; //hiire oma // 5.0f default
    public float rSpeed = 0.3f; //klaviatuuri oma     // 0.3f default

    void Start()
    {
        // Debug.Log(SensitivityController.mouseSensitivity);
        if (SensitivityController.mouseSensitivity != 0 && SensitivityController.keysSensitivity != 0)
        {
        aimSpeed = SensitivityController.mouseSensitivity;
        rSpeed = SensitivityController.keysSensitivity;
        }
        
    }

    void Update()
    {
        if (!PauseGame.gameIsPaused)
        {
            //for mouse aiming
            float aiming = aimSpeed * Input.GetAxis("Mouse X");
            transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, aiming);

            //for keyboard aiming
            if (Input.GetKey("left"))
            {
                transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, -(rSpeed));
            }
            if (Input.GetKey("right"))
            {
                transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, rSpeed);
            }
        }
    }
}
