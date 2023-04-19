using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField nameInput;
    string filename = "C:/Users/Pawe³/Desktop/praca-magisterska/praca_magisterska_gra_powazna/players_data_save.json";

    List<Player> players = new List<Player>();

    private void Start()
    {
        players = FileHandler.ReadListFromJSON(filename);
    }

    public void AddNameToList()
    {
        players.Add(new Player(nameInput.text, Random.Range(0, 100)));
        nameInput.text = "";

        FileHandler.SaveToJSON(players, filename);
    }
}