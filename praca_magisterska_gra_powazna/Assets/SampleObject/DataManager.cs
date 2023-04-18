using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    public PlayerData data;

    private string file = "C:/Users/Pawe³/Desktop/praca-magisterska/praca_magisterska_gra_powazna/player.txt";

    public void Save()
    {
        string json = JsonUtility.ToJson(data);
        WriteToFile(file, json);
    }

    public void Load()
    {
        data = new PlayerData();
        string json = ReadFromFile(file);
        UnityEngine.Debug.Log(json);
        JsonUtility.FromJsonOverwrite(json, data);
    }


    private void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using(StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }

    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using(StreamReader reader = new StreamReader(path))
            {
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else
        {
            UnityEngine.Debug.Log("File not found!");
        }
        return "";

    }

    private string GetFilePath(string fileName)
    {
        //return Application.persistentDataPath + "/" + fileName;
        return fileName;
    }

    private void Update()
    {
        UnityEngine.Debug.Log(data.name);
    }
}
