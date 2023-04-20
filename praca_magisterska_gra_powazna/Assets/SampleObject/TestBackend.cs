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
    public int currentQuestion = 1;
    //List<Question> questions = new List<Question> ();


    //string question_1;
    //Dictionary<string, bool> question_1_answers = new Dictionary<string, bool>(){
    //    { "Odpowiedz A", false },
    //    { "Odpowiedz B", false },
    //    { "Odpowiedz C", false }
    //};
    //string question_2;
    //Dictionary<string, bool> question_2_answers = new Dictionary<string, bool>(){
    //    { "Klucz1", false },
    //    { "Klucz2", false },
    //    { "Klucz3", false }
    //};
    //string question_3;
    //Dictionary<string, bool> question_3_answers = new Dictionary<string, bool>(){
    //    { "Klucz1", false },
    //    { "Klucz2", false },
    //    { "Klucz3", false }
    //};
    //string question_4;
    //Dictionary<string, bool> question_4_answers = new Dictionary<string, bool>(){
    //    { "Klucz1", false },
    //    { "Klucz2", false },
    //    { "Klucz3", false }
    //};


    public Text question;
    public Text answer_A;
    public Text answer_B;
    public Text answer_C;
    public Text answer_D;

    void Start()
    {
        printTextElementOnScreen(question, "");
        printTextElementOnScreen(answer_A, "");
        printTextElementOnScreen(answer_B, "");
        printTextElementOnScreen(answer_C, "");
        printTextElementOnScreen(answer_D, "");
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        switch (currentQuestion)
        {
            case 1:
                updateTextElementOnScreen(question, "Question 1");
                updateTextElementOnScreen(answer_A, "q 1 a A");
                updateTextElementOnScreen(answer_B, "q 1 a B");
                updateTextElementOnScreen(answer_C, "q 1 a C");
                updateTextElementOnScreen(answer_D, "q 1 a D");
                break;

            case 2:
                updateTextElementOnScreen(question, "Question 2");
                updateTextElementOnScreen(answer_A, "q 2 a A");
                updateTextElementOnScreen(answer_B, "q 2 a B");
                updateTextElementOnScreen(answer_C, "q 2 a C");
                updateTextElementOnScreen(answer_D, "q 2 a D");
                break;
            case 3:
                updateTextElementOnScreen(question, "Question 3");
                updateTextElementOnScreen(answer_A, "q 3 a A");
                updateTextElementOnScreen(answer_B, "q 3 a B");
                updateTextElementOnScreen(answer_C, "q 3 a C");
                updateTextElementOnScreen(answer_D, "q 3 a D");
                break;

        }
    }


    public void printTextElementOnScreen(Text textPrefab, string text, int x = -426, int y = 39, int fontSize = 47)
    {
        Text newText = Instantiate(textPrefab, transform);
        newText.text = text;
        newText.color = Color.white;
        newText.fontSize = fontSize;
        RectTransform rectTransform = newText.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(x, y);
    }

    public void updateTextElementOnScreen(Text textPrefab, string text)
    {
        textPrefab.text = text;
    }

    public void ChangeScoreValue()
    {
        score++;
    }

}