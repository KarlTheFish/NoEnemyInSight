using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Shooting : MonoBehaviour
{

    public float shootSpeed;
    public int bulletSize;

    private GameObject _aimThing;
    private bool ShootButtonPressed;
    private GameObject shot;
    private bool gameIsPaused;
    
    private void Awake()
    {
        _aimThing = GameObject.Find("AimThing");
        gameIsPaused = GameObject.Find("Level").GetComponent<PauseGame>().gameIsPaused;

        shootSpeed = GameObject.Find("WeaponInfo").GetComponent<WeaponInfo>().shootSpeed;
        bulletSize = GameObject.Find("WeaponInfo").GetComponent<WeaponInfo>().bulletSize;

    }
    
    // Update is called once per frame
    void Update()
    {
        if (!gameIsPaused) {
            if (Input.GetKeyDown(KeyCode.Space) && shot == null)
            {
                Debug.Log("Space pressed");
                gameObject.GetComponent<AudioSource>().Play(0);
                for (int i = 1; i < bulletSize; i++) {
                    gameObject.transform.localScale += Vector3.one;
                    Debug.Log("Bullet enlarged");
                }
                shot = Instantiate(_aimThing, _aimThing.transform.position, Quaternion.identity);
                shot.tag = "Shot";
                ShootButtonPressed = true;
            }

            if (ShootButtonPressed == true){
                Debug.Log("shot fired");
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
