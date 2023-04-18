using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiDataSave : MonoBehaviour
{
    public InputField playerName;
    public Text coins;
    public DataManager dataManager;

    private void Start()
    {
        dataManager.Load();
    }

    public void ClickCoin()
    {
        dataManager.data.coins += 1;
        coins.text = dataManager.data.coins.ToString();
    }

    public void ChangeName(string text)
    {
        dataManager.data.name = text;
    }

    public void ClickSave()
    {
        dataManager.Save();
    }
}
