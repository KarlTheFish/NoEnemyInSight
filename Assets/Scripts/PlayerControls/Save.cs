using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Save : MonoBehaviour
{
    private const string DataFile = "datasave.dat";

    private string _dataFilePath;
    private void Awake()
    {
        _dataFilePath = Path.Combine(Application.persistentDataPath, DataFile);
        if (!File.Exists(_dataFilePath))
        {
            CreateNewDataFile();
        }
    }

    private void CreateNewDataFile()
    {
        SaveFile(gameObject.AddComponent<PlayerStats>(), _dataFilePath);
    }

    public void SaveData(int score)
    {
        var playerStats = LoadResultsData();
        playerStats.score += score;
        SaveFile(playerStats, _dataFilePath);
    }

    private void SaveFile(object data, string path)
    {
        SaveFile(path, data);
    }

    private static void SaveFile(string filePath, object data)
    {
        File.WriteAllText(filePath, JsonUtility.ToJson(data));
    }

    private PlayerStats LoadResultsData()
    {
        return LoadData<PlayerStats>(_dataFilePath);
    }

    private static T LoadData<T>(string filePath)
    {
        return JsonUtility.FromJson<T>(File.ReadAllText(filePath));
    }

}
