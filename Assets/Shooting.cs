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
    private GameObject _shootPoint;
    private bool ShootButtonPressed;
    


    // Start is called before the first frame update
    private void Awake()
    {
        _aimThing = GameObject.Find("AimThing");
        _shootPoint = GameObject.FindWithTag("Shot");
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
        Instantiate(_aimThing, _aimThing.transform.position, Quaternion.identity);
        _aimThing.GetComponent<MoveWithAim>().enabled = false;
        gameObject.GetComponent<MoveWithAim>().enabled = false;
        transform.position = Vector3.MoveTowards(gameObject.transform.position, _aimThing.transform.position, Time.deltaTime * shootSpeed);
        if (gameObject.transform.position == _aimThing.transform.position) {
            ShootButtonPressed = false;
            transform.position = GameObject.Find("Player").transform.position;
            _aimThing.GetComponent<MoveWithAim>().enabled = true;
            gameObject.GetComponent<MoveWithAim>().enabled = true;
        }
    }
}
