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


    public Text question_1;
    public Text question_1_answer_A;
    public Text question_1_answer_B;
    public Text question_1_answer_C;
    public Text question_1_answer_D;
    //public Text question_2;

    //void Start()
    //{

    //}

    private void Update()
    {
        scoreText.text = score.ToString();
        switch (currentQuestion)
        {
            case 1:
                printTextElementOnScreen(question_1, "Question 1:");
                printTextElementOnScreen(question_1_answer_A, "Answer A", -426, 39 + 5);
                printTextElementOnScreen(question_1_answer_B, "Answer B", - 426, 39 + 10);
                printTextElementOnScreen(question_1_answer_C, "Answer C", - 426, 39 + 15);
                printTextElementOnScreen(question_1_answer_D, "Answer D", - 426, 39 + 20);
                break;
                
            //case 2:
            //    printTextElementOnScreen(question_2, "!!!!!!!!!");
            //    break;
                
        }
    }


    public void printTextElementOnScreen(Text textPrefab, string text, int x = -426, int y = 39, int fontSize = 47)
    {
        Text newText = Instantiate(textPrefab, transform); //to tworzy nowe obiekty w update!!!!!!!!
        newText.text = text;
        newText.color = Color.white;
        newText.fontSize = fontSize;
        RectTransform rectTransform = newText.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(x, y);
    }






    public void ChangeScoreValue()
    {
        score++;
    }

}