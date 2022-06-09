using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{
    private float shootSpeed = 5f;
    
    private GameObject _aimThing;
    private bool ShootButtonPressed;
    


    // Start is called before the first frame update
    private void Awake()
    {
        _aimThing = GameObject.Find("AimThing");
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ShootButtonPressed = true;
        }

        if (ShootButtonPressed == true)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, _aimThing.transform.position, Time.deltaTime * shootSpeed);
        if (gameObject.transform.position == _aimThing.transform.position) {
            ShootButtonPressed = false;
            transform.position = GameObject.Find("Player").transform.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
    }
}
