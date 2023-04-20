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
}

public class TestBackend : MonoBehaviour
{

    public Text scoreText;
    private int score = 0;
    public int currentQuestion = 1;

    public Text question;
    public Button answer_A_button;
    public Button answer_B_button;
    public Button answer_C_button;
    public Button answer_D_button;

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
        switch (currentQuestion)
        {
            case 1:
                updateTextElementOnScreen(question, "Który p³at mózgowy nie istnieje?");
                updateTextElementOnScreen(new Answer(answer_A_button, "czo³owy", false));
                updateTextElementOnScreen(new Answer(answer_B_button, "polityczny", false));
                updateTextElementOnScreen(new Answer(answer_C_button, "skroniowy", false));
                updateTextElementOnScreen(new Answer(answer_D_button, "ciemieniowy", false));
                break;

            case 2:
                updateTextElementOnScreen(question, "Lewa pó³kula odpowiada za:");
                updateTextElementOnScreen(new Answer(answer_A_button, "logikê", false));
                updateTextElementOnScreen(new Answer(answer_B_button, "kreatywnoœæ", false));
                updateTextElementOnScreen(new Answer(answer_C_button, "-", false, false));
                updateTextElementOnScreen(new Answer(answer_D_button, "-", false, false));
                break;
            case 3:
                updateTextElementOnScreen(question, "Osoba uderzy³a siê mocno w ty³ g³owy, i uszkodzi³a (?) p³at potyliczny. Jaki zmys³ móg³ ucierpieæ?", 20);
                updateTextElementOnScreen(new Answer(answer_A_button, "wzrok", false));
                updateTextElementOnScreen(new Answer(answer_B_button, "s³uch", false));
                updateTextElementOnScreen(new Answer(answer_C_button, "mowa", false));
                updateTextElementOnScreen(new Answer(answer_D_button, "wêch", false));
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

    public void updateTextElementOnScreen(Button answer, string text, bool isButtonActive = true)
    {
        if (isButtonActive)
        {
            answer.interactable = true;
            answer.GetComponentInChildren<Text>().text = text;
        }
        else
        {
            answer.GetComponentInChildren<Text>().text = text;
            answer.interactable = false;
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
        currentQuestion++;
    }

}