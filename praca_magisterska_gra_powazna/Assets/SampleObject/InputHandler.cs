using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Linq;
using System;

public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField nameInput;
    string filename = "players_data_save.json";

    List<Player> players = new List<Player>();

    private void Start()
    {
        players = ReadListFromJSON();
    }

    public void AddNameToList()
    {
        players.Add(new Player(nameInput.text, 2));
        nameInput.text = "";

        SaveToJSON(players);
    }

    public void SaveToJSON(List<Player> toSave)
    {
        Wrapper wrapper = new Wrapper();
        wrapper.items = toSave.ToArray();

        string content = JsonUtility.ToJson(wrapper, true); //do zmiany w razie erroru z jsonem i \n

        WriteFile(content);
    }

    public List<Player> ReadListFromJSON()
    {
        string content = ReadFile();

        if (string.IsNullOrEmpty(content) || content == "{}")
        {
            return new List<Player>();
        }
        Wrapper wrapper = JsonUtility.FromJson<Wrapper>(content);
        List<Player> res = wrapper.items.ToList();

        return res;

    }

    private void WriteFile(string content)
    {
        FileStream fileStream = new FileStream(filename, FileMode.Create);

        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            writer.Write(content);
        }
    }

    private  string ReadFile()
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string content = reader.ReadToEnd();
                return content;
            }
        }
        return "";
    }

    [Serializable]
    private class Wrapper
    {
        public Player[] items;
    }

}