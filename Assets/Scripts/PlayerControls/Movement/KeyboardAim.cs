using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardAim : MonoBehaviour
{
    private float rSpeed = 0.3f; //The aiming rotation speed. 1 is fast as fuck

    private bool _gameIsPaused;
    // Start is called before the first frame update
    void Start()
    {
        if (SensitivityController.keysSensitivity != 0)
        {
            rSpeed = SensitivityController.keysSensitivity;
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
            if (Input.GetKey("left"))
            {
                transform.Rotate(0f, -(rSpeed), 0f);
            }
            if (Input.GetKey("right"))
            {
                transform.Rotate(0f, rSpeed, 0f);
            }
        }
    }
}
