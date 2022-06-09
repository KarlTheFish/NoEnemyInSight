using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixAim : MonoBehaviour
{
    private float aimSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //for mouse aiming
        float aiming = aimSpeed * Input.GetAxis("Mouse X");
        transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, aiming);
        
        //for keyboard aiming
        float rSpeed = 0.3f;
        if (Input.GetKey("left")){
            transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, -(rSpeed));
        }
        if (Input.GetKey("right")){
            transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, rSpeed);
        }
    }
}
