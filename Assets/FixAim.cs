using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithAim : MonoBehaviour
{
    private float aimSpeed = 5.0f;

    private bool hasShot = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasShot == false) {
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

        if (Input.GetKey(KeyCode.Space))
        {
            hasShot = true;
        }

        if (hasShot == true)
        {
            transform.position = transform.position + Vector3.zero;
        }
        if (gameObject.transform.position == GameObject.Find("Gun").transform.position)
        {
            hasShot = false;
        }
    }
}