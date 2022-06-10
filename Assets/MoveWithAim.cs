using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithAim : MonoBehaviour
{
    private float aimSpeed = 5.0f; //hiire oma
    float rSpeed = 0.3f; //klaviatuuri oma
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (ControlsMenu.controls == "keys") // an object reference is required for 'ControlsMenu.controls'
        {
            //for mouse aiming
            float aiming = aimSpeed * Input.GetAxis("Mouse X");
            transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, aiming);
        } else 
        {
            //for keyboard aiming
            if (Input.GetKey("left")){
                transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, -(rSpeed));
            }
            if (Input.GetKey("right")){
                transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, rSpeed);
            }
        }
    }
}
