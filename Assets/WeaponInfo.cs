using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInfo : MonoBehaviour
{
    public int shootSpeed;
    public int bulletSize;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("WeaponMenu"))
        {
            shootSpeed = GameObject.Find("WeaponMenu").GetComponent<ChooseWeapon>().shootSpeed;
            bulletSize = GameObject.Find("WeaponMenu").GetComponent<ChooseWeapon>().bulletSize;
        }
    }
}
