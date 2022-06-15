using System.IO;
using UnityEngine;

public class JSONSave : MonoBehaviour
{
    private PlayerStatsJSON playerStatsJSON;

    private string path = "";
    private string persistentPath = "";

    // Start is called before the first frame update
    void Start()
    {
        CreatePlayerStats();
        SetPaths();
    }

    private void CreatePlayerStats()
    {
        //playerStatsJSON = new PlayerStatsJSON(0, 3);
    }

    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveData();
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            LoadData();
        }
    }

    public void SaveData()
    {
        string savePath = path;

        Debug.Log("Saving Data at " + savePath);
        string json = JsonUtility.ToJson(playerStatsJSON);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
    }

    public void LoadData()
    {
        using StreamReader reader = new StreamReader(path);
        string json = reader.ReadToEnd();

        PlayerStatsJSON stats = JsonUtility.FromJson<PlayerStatsJSON>(json);
        Debug.Log(stats.ToString());
    }
}
