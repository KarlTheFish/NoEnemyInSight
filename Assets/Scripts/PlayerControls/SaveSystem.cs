using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveStats (PlayerStats playerStats)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerStatsJSON data = new PlayerStatsJSON(playerStats);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static PlayerStatsJSON LoadStats()
    {
        string path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData.json";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerStatsJSON data = formatter.Deserialize(stream) as PlayerStatsJSON;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
