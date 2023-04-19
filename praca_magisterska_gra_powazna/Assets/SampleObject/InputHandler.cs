using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    [SerializeField] InputField nameInput;
    string filename = "C:/Users/Pawe³/Desktop/praca-magisterska/praca_magisterska_gra_powazna/players_data_save.json";

    List<InputEntry> entries = new List<InputEntry>();

    private void Start()
    {
        entries = FileHandler.ReadListFromJSON<InputEntry>(filename);
    }

    public void AddNameToList()
    {
        entries.Add(new InputEntry(nameInput.text, Random.Range(0, 100)));
        nameInput.text = "";

        FileHandler.SaveToJSON<InputEntry>(entries, filename);
    }
}