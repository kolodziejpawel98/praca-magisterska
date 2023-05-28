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

    public List<Player> players = new List<Player>();

    private void Start()
    {
        players = ReadListFromJSON();
    }

    public void printPlayerName(int index)
    {
        players = ReadListFromJSON();
        //p.r("!!!!!!!!!!!!!!!!!!!! = " + players[index].playerName);
    }

    public void AddNameToList()
    {
        if (!string.IsNullOrEmpty(nameInput.text))
        {
            setPlayersAsNotCurrentPlayer();
            players.Add(new Player(nameInput.text, UnityEngine.Random.Range(0, 100), true));
            nameInput.text = "";
            sortPlayers();
            SaveToJSON(players);
        }
    }

    public void sortPlayers()
    {
        players.Sort(comparePlayersScore);
    }

    private int comparePlayersScore(Player player_1, Player player_2)
    {
        if (player_1.points < player_2.points)
            return -1;
        else if (player_1.points > player_2.points)
            return 1;
        else
            return 0;
    }

    public void setPlayersAsNotCurrentPlayer()
    {
        foreach (var player in players)
        {
            player.isCurrentPlayer = false;
        }
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