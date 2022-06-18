using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChooseWeapon : MonoBehaviour
{
    public int bulletSize;
    public int shootSpeed;

    public void Pistol()
    {
        bulletSize = 1;
        shootSpeed = 7;
        Debug.Log("Pistol selected");
    }

    public void Shotgun()
    {
        bulletSize = 3;
        shootSpeed = 8;
        Debug.Log("Shotgun selected");
    }

    public void Rifle()
    {
        bulletSize = 1;
        shootSpeed = 10;
        Debug.Log("Rifle selected");
    }
    
}
