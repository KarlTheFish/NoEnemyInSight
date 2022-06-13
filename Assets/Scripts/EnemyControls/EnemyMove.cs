using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMove : MonoBehaviour
{

    //generates coordinates for a new enemy and creates an enemy
    void NewEnemy(){
        double enemyX = Random.Range(-10, 10);
        double enemyY = Random.Range(-10, 10);
        while ((enemyX > -5 && enemyX < 5) || (enemyY > -5 && enemyY < 5)) {
            enemyX = Random.Range(-10, 10);
            enemyY = Random.Range(-10, 10);
            if ((enemyX > -5 && enemyX < 5) || (enemyY > -5 && enemyY < 5) == false)
            {
                break;
            }
        }
        Instantiate(gameObject, new Vector3((float)enemyX, 0, (float)enemyY), Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {
        //enemy moves towards the player
        transform.position = Vector3.MoveTowards(gameObject.transform.position, GameObject.Find("Player").transform.position, Time.deltaTime);
        //if the enemy hits the player
        if (transform.position == GameObject.Find("Player").transform.position) {
            //playerHit = true;
            NewEnemy();
            Destroy(gameObject);
            if (GameObject.Find("Player").GetComponent<PlayerStats>().secretHealth > 0)
            {
                GameObject.Find("Player").GetComponent<PlayerStats>().secretHealth--;
            }
            else
            {
                Debug.Log("Got hit");
                GameObject.Find("Player").GetComponent<AudioSource>().Play(0);
                GameObject.Find("Player").GetComponent<PlayerStats>().playerHealth--;
            }
        }
    }

    //if the enemy is shot
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Test");
        NewEnemy();
        Destroy(gameObject); 
        GameObject.Find("Player").GetComponent<PlayerStats>().score++;
    }
}