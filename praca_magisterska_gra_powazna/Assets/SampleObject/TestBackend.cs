using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Answer
{
    public Button answerButton;
    public string answerText;
    public bool isAnswerCorrect;
    public bool isButtonActive;

    public Answer(Button answerButton, string answerText, bool isAnswerCorrect, bool isButtonActive = true)
    {
        this.answerText = answerText;
        this.answerButton = answerButton;
        this.isAnswerCorrect = isAnswerCorrect;
        this.isButtonActive = isButtonActive;
    }

    public void answerCorectnessHandler()
    {
        p.r("HANDLER!!!");
        if (isAnswerCorrect)
        {
            answerButton.onClick.AddListener(correctAnswerHandler);
        }
        else
        {
            answerButton.onClick.AddListener(wrongAnswerHandler);
        }
    }

    public void correctAnswerHandler()
    {
        p.r("Correct answer! :)");
    }
    public  void wrongAnswerHandler()
    {
        p.r("Wrong answer! :(");
    }
}

public class TestBackend : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    public int currentQuestionNumber = 1;
    public bool enterOnceInUpdate = false;

    public Text question;
    public Button answer_A_button;
    public Button answer_B_button;
    public Button answer_C_button;
    public Button answer_D_button;
    List<Answer> answers = new List<Answer>();


    void Start()
    {
        printTextElementOnScreen(question);
        printTextElementOnScreen(answer_A_button);
        printTextElementOnScreen(answer_B_button);
        printTextElementOnScreen(answer_C_button);
        printTextElementOnScreen(answer_D_button);
        
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        switch (currentQuestionNumber)
        {
            case 1:
                if (!enterOnceInUpdate)
                {
                    answers.Add(new Answer(answer_A_button, "czo³owy", false));
                    answers.Add(new Answer(answer_B_button, "polityczny", true));
                    answers.Add(new Answer(answer_C_button, "skroniowy", false));
                    answers.Add(new Answer(answer_D_button, "ciemieniowy", false));

                    updateTextElementOnScreen(question, "Który p³at mózgowy nie istnieje?");
                    updateTextElementOnScreen(answers);
                    foreach (var answer in answers)
                    {
                        answer.answerCorectnessHandler();
                    }
                    enterOnceInUpdate = true;
                }
                
                break;

            case 2:
                if (!enterOnceInUpdate)
                {
                    updateTextElementOnScreen(question, "Lewa pó³kula odpowiada za:");
                    updateTextElementOnScreen(new Answer(answer_A_button, "logikê", false));
                    updateTextElementOnScreen(new Answer(answer_B_button, "kreatywnoœæ", false));
                    updateTextElementOnScreen(new Answer(answer_C_button, "-", false, false));
                    updateTextElementOnScreen(new Answer(answer_D_button, "-", false, false));
                    enterOnceInUpdate = true;
                }
                break;
            case 3:
                if (!enterOnceInUpdate)
                {
                    updateTextElementOnScreen(question, "Osoba uderzy³a siê mocno w ty³ g³owy, i uszkodzi³a (?) p³at potyliczny. Jaki zmys³ móg³ ucierpieæ?", 20);
                    updateTextElementOnScreen(new Answer(answer_A_button, "wzrok", false));
                    updateTextElementOnScreen(new Answer(answer_B_button, "s³uch", false));
                    updateTextElementOnScreen(new Answer(answer_C_button, "mowa", false));
                    updateTextElementOnScreen(new Answer(answer_D_button, "wêch", false));
                    enterOnceInUpdate = true;
                }
                break;

        }
    }

    public void printTextElementOnScreen(Button answer, string text = "", int x = -426, int y = 39, int fontSize = 47)
    {
        Text textPrefab = answer.GetComponentInChildren<Text>();
        Text newText = Instantiate(textPrefab, transform);
        newText.text = text;
        newText.color = Color.white;
        newText.fontSize = fontSize;
        RectTransform rectTransform = newText.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(x, y);
    }

    public void printTextElementOnScreen(Text answer, string text = "", int x = -426, int y = 39, int fontSize = 47)
    {
        Text newText = Instantiate(answer, transform);
        newText.text = text;
        newText.color = Color.white;
        newText.fontSize = fontSize;
        RectTransform rectTransform = newText.GetComponent<RectTransform>();
        rectTransform.anchoredPosition = new Vector2(x, y);
    }

    public void updateTextElementOnScreen(Answer answer)
    {
        if (answer.isButtonActive)
        {
            answer.answerButton.interactable = true;
        }
        else
        {
            answer.answerButton.interactable = false;
        }

        answer.answerButton.GetComponentInChildren<Text>().text = answer.answerText;
    }

    public void updateTextElementOnScreen(List<Answer> answers)
    {
        foreach (var answer in answers)
        {
            if (answer.isButtonActive)
            {
                answer.answerButton.interactable = true;
            }
            else
            {
                answer.answerButton.interactable = false;
            }

            answer.answerButton.GetComponentInChildren<Text>().text = answer.answerText;
        } 
    }

    public void updateTextElementOnScreen(Text answer, string text, int fontSize = 47, bool isButtonActive = true)
    {
        answer.GetComponentInChildren<Text>().text = text;
        answer.GetComponentInChildren<Text>().fontSize = fontSize;
    }


    public void ChangeScoreValue()
    {
        score++;
    }

    public void nextQuestion()
    {
        currentQuestionNumber++;
    }

}