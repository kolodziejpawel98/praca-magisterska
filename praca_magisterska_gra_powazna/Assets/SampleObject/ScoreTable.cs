using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTable : MonoBehaviour
{
    public InputHandler inputHandler;


    public GameObject prefabTekstu; // Prefab obiektu Text do utworzenia

    void Start()
    {
        printPlayerScore();   
    }

    public void printPlayerScore()
    {
        for (int i = 0; i < inputHandler.players.Count; i++)
        {
            GameObject nowyTekst = Instantiate(prefabTekstu, transform);
            nowyTekst.transform.position = new Vector3(250, i * 100, 0);
            nowyTekst.GetComponent<Text>().text = inputHandler.players[i].playerName;
        }
    }



    //public void printTextElementOnScreen(Text answer, string text = "", int x = -426, int y = 39, int fontSize = 47)
    //{
    //    //Text textPrefab = answer.GetComponentInChildren<Text>();
    //    Text textPrefab = answer;
    //    Text newText = Instantiate(textPrefab, transform);
    //    newText.text = text;
    //    newText.color = Color.white;
    //    newText.fontSize = fontSize;
    //    RectTransform rectTransform = newText.GetComponent<RectTransform>();
    //    rectTransform.anchoredPosition = new Vector2(x, y);
    //}
}
