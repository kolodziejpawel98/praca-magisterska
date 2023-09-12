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

    public GameObject textInputError;
    public GameObject textInputErrorWhiteBox;
    public static bool isPlayerNameCorrect = false;
    public List<Player> players = new List<Player>();

    private void Start()
    {
        players = ReadListFromJSON();
    }

    public void printPlayerName(int index)
    {
        players = ReadListFromJSON();
    }

    public void AddNameToList()
    {
        bool doesNameAlreadyExist = false;
        foreach (var player in players)
        {
            if(string.Equals(player.playerName, nameInput.text))
            {
                doesNameAlreadyExist = true;
            }
        }

        if (!string.IsNullOrEmpty(nameInput.text) && !doesNameAlreadyExist)
        {
            isPlayerNameCorrect = true;
            setPlayersAsNotCurrentPlayer();
            players.Add(new Player(nameInput.text, UnityEngine.Random.Range(0, 100), true));
            nameInput.text = "";
            sortPlayers();
            SaveToJSON(players);
        }
        else
        {
            nameInput.text = "";
            textInputError.SetActive(true);
            textInputErrorWhiteBox.SetActive(true);
        }
    }

    public void sortPlayers()
    {
        players.Sort(comparePlayersScore);
    }

    private int comparePlayersScore(Player player_1, Player player_2)
    {
        if (player_1.points > player_2.points)
            return -1;
        else if (player_1.points < player_2.points)
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

    public  void resetCurrentPlayerScore()
    {
        foreach (var player in players)
        {
            if (player.isCurrentPlayer) {
                p.r("zeruje wynik gracza: " + player.playerName);
                p.r("jego wynik = " + player.points);
                player.points = 0.0f;
                p.r("jego wynik po zerowaniu = " + player.points);
                SaveToJSON(players);
            }
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