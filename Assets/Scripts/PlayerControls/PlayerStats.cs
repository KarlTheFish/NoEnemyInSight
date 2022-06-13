using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public Save save;
    public Levels levels;

    public int score;
    public int playerHealth;
    public int secretHealth;

    public void saveStuff()
    {
        if (playerHealth == 0 || levels.level1 == 0)
        {
            save.SaveData(score);
        }
    }
}
