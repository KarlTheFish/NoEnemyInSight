using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class ChooseWeapon : MonoBehaviour
{
    public void Pistol()
    {
        WeaponController.pistol = true;
        WeaponController.shotgun = false;
        WeaponController.rifle = false;
    }

    public void Shotgun()
    {
        WeaponController.pistol = false;
        WeaponController.shotgun = true;
        WeaponController.rifle = false;
    }

    public void Rifle()
    {
        WeaponController.pistol = false;
        WeaponController.shotgun = false;
        WeaponController.rifle = true;
    }
}
