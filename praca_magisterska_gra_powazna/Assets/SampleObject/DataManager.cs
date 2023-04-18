using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    //public PlayerData data;
    public List<PlayerData> data= new List<PlayerData>();

    private string file = "C:/Users/Pawe³/Desktop/praca-magisterska/praca_magisterska_gra_powazna/player.txt";

    public void Save()
    {
        string json = JsonUtility.ToJson(data[data.Count - 1]);
        UnityEngine.Debug.Log("SIZE = " + data.Count);
        WriteToFile(file, json);
    }

    public void Load()
    {
        //data = new PlayerData();
        PlayerData emptyPlayerData = new PlayerData();
        data.Add(emptyPlayerData);

        string json = ReadFromFile(file);
        JsonUtility.FromJsonOverwrite(json, data[data.Count - 1]);
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
                UnityEngine.Debug.Log("json = " + json);
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

    //public void humanizeJsonData(string json)
    //{
    //    PlayerData[] players = JsonUtility.FromJson<PlayerData>("[" + json + "]");

    //    // Wyci¹gniêcie wartoœci "name" z ka¿dego obiektu
    //    foreach (PlayerData player in players)
    //    {
    //        Debug.Log("Name: " + player.name);
    //    }
    //}

}





//using UnityEngine;

//[System.Serializable]
//public class PlayerData
//{
//    public string name;
//    public int coins;
//}

//public class JSONReadExample : MonoBehaviour
//{
//    private string jsonString = "{\"name\":\"jessie pinkman\",\"coins\":0}{\"name\":\"gfdhjkl\",\"coins\":0}{\"name\":\"dsdsdsds\",\"coins\":0}{\"name\":\"dsdsdsds\",\"coins\":0}{\"name\":\"hank schraider\",\"coins\":0}";

//    void Start()
//    {
//        // Odczytanie danych z JSON
//        PlayerData[] players = JsonUtility.FromJson<PlayerData>("[" + jsonString + "]");

//        // Wyci¹gniêcie wartoœci "name" z ka¿dego obiektu
//        foreach (PlayerData player in players)
//        {
//            Debug.Log("Name: " + player.name);
//        }
//    }
//}
