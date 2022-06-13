using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMove : MonoBehaviour
{
    public PlayerStats playerStats;
    public Levels levels;
    //generates coordinates for a new enemy and creates an enemy
    void NewEnemy(){
        if (levels.level1 > 1 && playerStats.playerHealth > 1) //dont know why || doesnt work and %% does; cant be less than 1?
        {
            double enemyX = Random.Range(-10, 10);
            double enemyY = Random.Range(-10, 10);
            while ((enemyX > -5 && enemyX < 5) || (enemyY > -5 && enemyY < 5))
            {
                enemyX = Random.Range(-10, 10);
                enemyY = Random.Range(-10, 10);
                if ((enemyX > -5 && enemyX < 5) || (enemyY > -5 && enemyY < 5) == false)
                {
                    break;
                }
            }
            Instantiate(gameObject, new Vector3((float)enemyX, 0, (float)enemyY), Quaternion.identity);
        }
        else
        {
            Debug.Log("Game has ended");
        }
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
            if (playerStats.secretHealth > 0)
            {
                playerStats.secretHealth--;
            }
            else
            {
                Debug.Log("Player hit");
                GameObject.Find("Player").GetComponent<AudioSource>().Play(0);
                playerStats.playerHealth--;
                levels.level1--;
            }
        }
    }

    //if the enemy is shot
    private void OnTriggerEnter(Collider other) {
        Debug.Log("Enemy hit");
        NewEnemy();
        Destroy(gameObject);
        playerStats.score++;
        levels.level1--;
    }
}