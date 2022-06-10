using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAim : MonoBehaviour
{
    // Start is called before the first frame update
    float aimSpeed = 5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float aiming = aimSpeed * Input.GetAxis("Mouse X");
        
        transform.Rotate(0, aiming, 0);
    }
}
