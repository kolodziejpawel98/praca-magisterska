using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataManager : MonoBehaviour
{
    //public PlayerData data;
    public List<PlayerData> players = new List<PlayerData>();

    private string file = "C:/Users/Pawe³/Desktop/praca-magisterska/praca_magisterska_gra_powazna/player.txt";

    public void Save()
    {
        UnityEngine.Debug.Log("SIZE PRZED = " + players.Count);
        string json = JsonUtility.ToJson(players[players.Count - 1]);
        print("JSON!!!!!!!!! = " + json);
        //UnityEngine.Debug.Log("SIZE = " + players.Count);
        WriteToFile(file, json);
    }

    public void Load()
    {
        addNewPlayerPlaceholder();
        string fileContentInJson = ReadFromFile(file);
        JsonUtility.FromJsonOverwrite(fileContentInJson, players[players.Count - 1]);
    }

    public void addNewPlayer(string playerName)
    {
        //print("addNewPLayer method. playerName = " + playerName);
        //print("before add new player: players.size = " + players.Count + ". Last element = " + players[players.Count - 1].name);
        addNewPlayerPlaceholder();
        players[players.Count - 1].name = playerName;
        //print("after add new player: players.size = " + players.Count + ". Last element = " + players[players.Count - 1].name);
    }

    private void WriteToFile(string fileName, string json)
    {
        string path = GetFilePath(fileName);
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(json);
        }
    }

    private string ReadFromFile(string fileName)
    {
        string path = GetFilePath(fileName);
        if (File.Exists(path))
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string fileContent = reader.ReadToEnd();
                UnityEngine.Debug.Log("File content = " + fileContent);
                return fileContent;
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

    public void addNewPlayerPlaceholder()
    {
        PlayerData emptyPlayerData = new PlayerData();
        players.Add(emptyPlayerData);
    }

    public void print(string text)
    {
        UnityEngine.Debug.Log(text);
    }
}