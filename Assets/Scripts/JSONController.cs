using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONController : MonoBehaviour
{
    public string jsonURL;

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
        if(_www.error == null)
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
        JSONDataClass jsnData = JsonUtility.FromJson<JSONDataClass>(_url);
        Debug.Log(jsnData.weapon);
        Debug.Log(jsnData.weapons);
    }
}
