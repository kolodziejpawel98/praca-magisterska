using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiDataSave : MonoBehaviour
{
    public InputField playerNameInputField;
    public Text coins;
    public DataManager dataManager;

    private void Start()
    {
        dataManager.Load();
        UnityEngine.Debug.Log("Koniec startu. Players size = " + dataManager.players.Count + ". Player[0] name = " + dataManager.players[dataManager.players.Count - 1].name);
    }

    public void LoadNewObject()
    {
        dataManager.Load();
    }

    public void ClickCoin()
    {
        //dataManager.data.coins += 1;
        //coins.text = dataManager.data.coins.ToString();
    }

    //public void ChangeName(string playerNameInputField)
    //{
    //    //UnityEngine.Debug.Log("SIZE PRZED zmiana imiennia w inpucie = " + dataManager.players.Count);
    //    //dataManager.players[dataManager.players.Count - 1].name = playerNameInputField;
    //    dataManager.addNewPlayer(playerNameInputField);
    //}

    public void enterName()
    {
        dataManager.addNewPlayer(playerNameInputField.text);
    }

    public void ClickSave()
    {
        dataManager.Save();
    }
}
