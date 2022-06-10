using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONtest : MonoBehaviour
{
    public string jsonURL;

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
        StartCoroutine(getData());
    }

    IEnumerator getData()
    {
        Debug.Log("Loading");

        WWW _www = new WWW(jsonURL);
        yield return _www;
        if (_www.error == null)
        {
            processJsonData(_www.text);
        }
        else
        {
            Debug.Log("Error");
        }
    }

    private void processJsonData(string _url)
    {
        myWeaponList = JsonUtility.FromJson<WeaponList>(_url);
    }

}
