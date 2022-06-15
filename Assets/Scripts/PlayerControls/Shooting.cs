using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{
    private float shootSpeed;
    
    private GameObject _aimThing;
    private bool ShootButtonPressed;
    private GameObject shot;
    


    // Start is called before the first frame update
    private void Awake()
    {
        _aimThing = GameObject.Find("AimThing");
        shootSpeed = GameObject.Find("Gun").GetComponent<WeaponParameters>().ShootSpeed;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && shot == null)
        {
            for (int i = 1; i < GetComponent<WeaponParameters>().BulletAmount; i++)
            {
                gameObject.transform.localScale += Vector3.one;
                Debug.Log("Bullet enlarged");
            }
            gameObject.GetComponent<AudioSource>().Play(0);
            shot = Instantiate(_aimThing, _aimThing.transform.position, Quaternion.identity);
            shot.tag = "Shot";
            _aimThing.transform.RotateAround(GameObject.Find("Player").transform.position, Vector3.up, 5.0f);
            ShootButtonPressed = true;
            Debug.Log("shot fired");
        }

        if (ShootButtonPressed == true)
        {
            for (int i = 0; i < GetComponent<WeaponParameters>().BulletAmount; i++)
            {
                Shoot();
            }
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
            gameObject.transform.localScale = Vector3.one;
        }
    }
}
