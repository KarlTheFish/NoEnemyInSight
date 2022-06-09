using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset textJSON;

    [System.Serializable]
    public class Weapon
    {
        public string name;
        public double firerate;
    }

    [System.Serializable]
    public class WeaponList
    {
        public Weapon[] weapon;
    }

    public WeaponList myWeaponList = new WeaponList();

    // Start is called before the first frame update
    void Start()
    {
        myWeaponList = JsonUtility.FromJson<WeaponList>(textJSON.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
