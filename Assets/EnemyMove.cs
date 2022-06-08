using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMove : MonoBehaviour
{
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
        transform.position = Vector3.MoveTowards(gameObject.transform.position, GameObject.Find("Player").transform.position, Time.deltaTime);
        if(gameObject.transform.position == GameObject.Find("Player").transform.position){
            NewEnemy();
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);
        //NewEnemy();
    }
}
