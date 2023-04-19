using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//enum answer
//{
//    A,
//    B,
//    C,
//    D
//}


public class Question
{
    string questionText;
    Dictionary<string, bool> answer = new Dictionary<string, bool>();
}

public class TestBackend : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;
    List<Question> pytania = new List<Question> ();

    public Text textPrefab;

    void Start()
    {
        Text newText = Instantiate(textPrefab, transform);
        newText.text = "Przyk³adowy tekst!!!!!!!!!!!!!";
        newText.color = Color.white;
        newText.fontSize = 47;
        RectTransform rectTransform = newText.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(-426, 39);
        //rectTransform.sizeDelta = new Vector2(200, 100); // Rozmiar tekstu na panelu UI
    }





    private void Update()
    {
        scoreText.text = score.ToString();
    }



    public void ChangeScoreValue()
    {
        score++;
    }

}