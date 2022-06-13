using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int score;
    public int playerHealth;
    public int secretHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 3;
        score = 0;
        secretHealth = 1;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
