using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponStatus : MonoBehaviour
{
    public GameObject pistol;
    public GameObject shotgun;
    public GameObject rifle;

    private void Awake()
    {
        pistol = GameObject.Find("Pistol");
        shotgun = GameObject.Find("Shotgun");
        rifle = GameObject.Find("Rifle");
    }

    private void Update()
    {
        pistol.SetActive(WeaponController.pistol);
        shotgun.SetActive(WeaponController.shotgun);
        rifle.SetActive(WeaponController.rifle);
    }
}
