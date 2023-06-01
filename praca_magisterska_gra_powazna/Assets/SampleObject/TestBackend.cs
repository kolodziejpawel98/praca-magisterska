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
        if (isAnswerCorrect)
        {
            answerButton.onClick.AddListener(correctAnswerHandler);
        }
        else
        {
            answerButton.onClick.AddListener(wrongAnswerHandler);
        }
    }

    public void removeButtonListener()
    {
        answerButton.onClick.RemoveAllListeners();
    }

    public void correctAnswerHandler()
    {
        Timer.StopTimer();
        TestBackend.timeScore = Timer.GetElapsedTimeInSeconds();
        TestBackend.score += Timer.calculateTimeToPoints();
        answerButton.image.color = Color.green;
    }
    public  void wrongAnswerHandler()
    {
        answerButton.image.color = Color.red;
    }

    public void resetEverything()
    {
        removeButtonListener();
        answerButton.image.color = Color.white;
    }
}

public class TestBackend : MonoBehaviour
{
    public Text scoreText;
    public static float score = 0.0f;
    public Text timeScoreText;
    public static float timeScore = 0.0f;

    public int currentQuestionNumber = 1;
    public bool enterOnceInUpdate = false;

    public Text question;
    public Button answer_A_button;
    public Button answer_B_button;
    public Button answer_C_button;
    public Button answer_D_button;
    List<Answer> answers = new List<Answer>();

    public Button goToResumeButton;

    void Start()
    {
        goToResumeButton.interactable = false;
        printTextElementOnScreen(question);
        printTextElementOnScreen(answer_A_button);
        printTextElementOnScreen(answer_B_button);
        printTextElementOnScreen(answer_C_button);
        printTextElementOnScreen(answer_D_button); 
    }

    private void Update()
    {
        scoreText.text = score.ToString();
        timeScoreText.text = timeScore.ToString();
        switch (currentQuestionNumber)
        {
            case 1:
                if (!enterOnceInUpdate)
                {
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, "Kt�ry p�at m�zgowy nie istnieje?");

                    answers.Add(new Answer(answer_A_button, "czo�owy", false));
                    answers.Add(new Answer(answer_B_button, "polityczny", true));
                    answers.Add(new Answer(answer_C_button, "skroniowy", false));
                    answers.Add(new Answer(answer_D_button, "ciemieniowy", false));
                    updateTextElementOnScreen(answers);

                    enterOnceInUpdate = true;
                }
                break;
            case 2:
                if (!enterOnceInUpdate)
                {
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, "Lewa p�kula odpowiada za:");

                    answers.Add(new Answer(answer_A_button, "logik�", true));
                    answers.Add(new Answer(answer_B_button, "kreatywno��", false));
                    answers.Add(new Answer(answer_C_button, "-", false, false));
                    answers.Add(new Answer(answer_D_button, "-", false, false));
                    updateTextElementOnScreen(answers);

                    enterOnceInUpdate = true;
                }
                break;
            case 3:
                if (!enterOnceInUpdate)
                {
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, "Osoba uderzy�a si� mocno w ty� g�owy, i uszkodzi�a (?) p�at potyliczny. Jaki zmys� m�g� ucierpie�?", 20);

                    answers.Add(new Answer(answer_A_button, "wzrok", true));
                    answers.Add(new Answer(answer_B_button, "s�uch", false));
                    answers.Add(new Answer(answer_C_button, "mowa", false));
                    answers.Add(new Answer(answer_D_button, "w�ch", false));
                    updateTextElementOnScreen(answers);

                    enterOnceInUpdate = true;
                    goToResumeButton.interactable = true;
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
            answer.answerCorectnessHandler();
            answer.answerButton.GetComponentInChildren<Text>().text = answer.answerText;
        } 
    }

    public void updateTextElementOnScreen(Text answer, string text, int fontSize = 47, bool isButtonActive = true)
    {
        answer.GetComponentInChildren<Text>().text = text;
        answer.GetComponentInChildren<Text>().fontSize = fontSize;
    }

    public void nextQuestion()
    {
        currentQuestionNumber++;
        enterOnceInUpdate = false;

        foreach (var answer in answers)
        {
            answer.resetEverything();
        }
        answers.RemoveRange(0, 4);
    }

}