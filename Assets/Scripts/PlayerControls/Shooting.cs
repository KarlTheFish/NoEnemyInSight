using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{
    private float shootSpeed = 10f;
    
    private GameObject _aimThing;
    private GameObject _shootPoint;
    private bool ShootButtonPressed;
    private GameObject shot;
    


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
        if (Input.GetKeyDown(KeyCode.Space) && shot == null)
        {
            gameObject.GetComponent<AudioSource>().Play(0);
            shot = Instantiate(_aimThing, _aimThing.transform.position, Quaternion.identity);
            shot.tag = "Shot";
            ShootButtonPressed = true;
        }

        if (ShootButtonPressed == true)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        gameObject.GetComponent<SphereCollider>().isTrigger = true;
        shot.GetComponent<MoveWithAim>().enabled = false;
        gameObject.GetComponent<MoveWithAim>().enabled = false;
        transform.position = Vector3.MoveTowards(gameObject.transform.position, shot.transform.position, Time.deltaTime * shootSpeed);
        if (gameObject.transform.position == shot.transform.position) {
            ShootButtonPressed = false;
            transform.position = GameObject.Find("Player").transform.position;
            Destroy(shot);
            gameObject.GetComponent<MoveWithAim>().enabled = true;
            gameObject.GetComponent<SphereCollider>().isTrigger = false;
        }
    }
}
