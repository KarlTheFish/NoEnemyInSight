using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMove : MonoBehaviour
{
    public PlayerStats playerStats;
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
            NewEnemy();
            Destroy(gameObject);
            playerStats.playerHealth--;
        }
    }

    //if the enemy is shot
    private void OnTriggerEnter(Collider other) {
        NewEnemy();
        Destroy(gameObject);
        playerStats.score++;
    }
}