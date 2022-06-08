using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    private float shootSpeed = 0.5f;

    private string FireButton = "Space"; //hiljem muudame seda
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, GameObject.Find("AimThing").transform.position, Time.deltaTime);
        }
    }
}
