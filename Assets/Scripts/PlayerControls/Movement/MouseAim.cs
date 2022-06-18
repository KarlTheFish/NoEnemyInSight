using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    // Start is called before the first frame update
    float aimSpeed = 5f;

    private bool _gameIsPaused;
    void Start()
    {
        if (SensitivityController.mouseSensitivity != 0)
        {
            aimSpeed = SensitivityController.mouseSensitivity;
        }
    }

    void Awake()
    {
        _gameIsPaused = GameObject.Find("Level").GetComponent<PauseGame>().gameIsPaused;
    }

    // Update is called once per frame
    void Update()
    {
        if (!_gameIsPaused)
        {
            float aiming = aimSpeed * Input.GetAxis("Mouse X");

            transform.Rotate(0, aiming, 0);
        }
    }
}
