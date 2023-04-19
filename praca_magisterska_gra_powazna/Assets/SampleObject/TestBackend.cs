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


//public class Question
//{
//    string questionText;
//    Dictionary<string, bool> answer = new Dictionary<string, bool>();

//    public Question(string questionText,
//                    string answer_A, bool isAnswerAcorrect,
//                    string answer_B, bool isAnswerBcorrect,
//                    string answer_C, bool isAnswerCcorrect,
//                    string answer_D, bool isAnswerDcorrect
//                    )
//    {
//        this.questionText = questionText;
//        answer.Add(answer_A, isAnswerAcorrect);
//        answer.Add(answer_B, isAnswerBcorrect);
//        answer.Add(answer_C, isAnswerCcorrect);
//        answer.Add(answer_D, isAnswerDcorrect);
//    }

//    public void print()
//    {
//        p.r(answer.Count.ToString());
//    }
//}

public class TestBackend : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;
    //List<Question> questions = new List<Question> ();


    string question_1;
    Dictionary<string, bool> question_1_answers = new Dictionary<string, bool>(){
        { "Odpowiedz A", false },
        { "Odpowiedz B", false },
        { "Odpowiedz C", false }
    };
    string question_2;
    Dictionary<string, bool> question_2_answers = new Dictionary<string, bool>(){
        { "Klucz1", false },
        { "Klucz2", false },
        { "Klucz3", false }
    };
    string question_3;
    Dictionary<string, bool> question_3_answers = new Dictionary<string, bool>(){
        { "Klucz1", false },
        { "Klucz2", false },
        { "Klucz3", false }
    };
    string question_4;
    Dictionary<string, bool> question_4_answers = new Dictionary<string, bool>(){
        { "Klucz1", false },
        { "Klucz2", false },
        { "Klucz3", false }
    };


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