//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class Answer
//{
//    public Button answerButton;
//    public string answerText;
//    public bool isAnswerCorrect;
//    public bool isButtonActive;

//    List<Answer> answers = new List<Answer>();

//    public Answer(){}

//    public Answer(Button answerButton, string answerText, bool isAnswerCorrect, bool isButtonActive)
//    {
//        this.answerText = answerText;
//        this.answerButton = answerButton;
//        this.isAnswerCorrect = isAnswerCorrect;
//        this.isButtonActive = isButtonActive;
//    }

//    public void addAnswer(Button answerButton, string answerText, bool isAnswerCorrect, bool isButtonActive = true)
//    {
//        answers.Add(new Answer(answerButton, answerText, isAnswerCorrect, isButtonActive));
//    }

//    public void answerCorectnessHandler(List<Answer> answers)
//    {
//        if (isAnswerCorrect)
//        {
//            answerButton.onClick.AddListener(() => correctAnswerHandler(answers));

//        }
//        else
//        {
//            answerButton.onClick.AddListener(wrongAnswerHandler);
//        }
//    }

//    public void removeButtonListener()
//    {
//        answerButton.onClick.RemoveAllListeners();
//    }

//    public void correctAnswerHandler(List<Answer> answers)
//    {
//        Timer.StopTimer();
//        TestBackend.timeScore = Timer.GetElapsedTimeInSeconds();
//        TestBackend.score += Timer.calculateTimeToPoints();
//        answerButton.image.color = Color.green;
//        foreach (var answer in answers)
//        {
//            if (!answer.isAnswerCorrect)
//            {
//                answer.answerButton.interactable = false;
//            }
//        }
//    }

//    public  void wrongAnswerHandler()
//    {
//        answerButton.image.color = Color.red;
//    }

//    public void resetEverything()
//    {
//        removeButtonListener();
//        answerButton.image.color = Color.white;
//    }
//}

//public class TestBackend : MonoBehaviour
//{
//    public Text scoreText;
//    public static float score = 0.0f;
//    public Text timeScoreText;
//    public static float timeScore = 0.0f;

//    public int currentQuestionNumber = 1;
//    public bool enterOnceInUpdate = false;

//    public Text question;
//    public Button answer_A_button;
//    public Button answer_B_button;
//    public Button answer_C_button;
//    public Button answer_D_button;
//    //List<Answer> answers = new List<Answer>();
//    Answer answers;

//    public GameObject buttonGoToResume;
//    public GameObject buttonNextQuestion;

//    void Start()
//    {
//        //goToResumeButton.interactable = false;
//        buttonGoToResume.SetActive(false);
//        printTextElementOnScreen(question);
//        printTextElementOnScreen(answer_A_button);
//        printTextElementOnScreen(answer_B_button);
//        printTextElementOnScreen(answer_C_button);
//        printTextElementOnScreen(answer_D_button); 
//    }

//    private void Update()
//    {
//        scoreText.text = score.ToString();
//        timeScoreText.text = timeScore.ToString();
//        switch (currentQuestionNumber)
//        {
//            case 1:
//                if (!enterOnceInUpdate)
//                {
//                    Timer.StartTimer();
//                    updateTextElementOnScreen(question, "Który p³at mózgowy nie istnieje?");

//                    answers.addAnswer(answer_A_button, "czo³owy", false);
//                    answers.addAnswer(answer_B_button, "polityczny", true);
//                    answers.addAnswer(answer_C_button, "skroniowy", false);
//                    answers.addAnswer(answer_D_button, "ciemieniowy", false);
//                    updateTextElementOnScreen(answers);

//                    enterOnceInUpdate = true;
//                }
//                break;
//            case 2:
//                if (!enterOnceInUpdate)
//                {
//                    Timer.StartTimer();
//                    updateTextElementOnScreen(question, "Lewa pó³kula odpowiada za:");

//                    answers.Add(new Answer(answer_A_button, "logikê", true));
//                    answers.Add(new Answer(answer_B_button, "kreatywnoœæ", false));
//                    answers.Add(new Answer(answer_C_button, "-", false, false));
//                    answers.Add(new Answer(answer_D_button, "-", false, false));
//                    updateTextElementOnScreen(answers);

//                    enterOnceInUpdate = true;
//                }
//                break;
//            case 3:
//                if (!enterOnceInUpdate)
//                {
//                    Timer.StartTimer();
//                    updateTextElementOnScreen(question, "Osoba uderzy³a siê mocno w ty³ g³owy, i uszkodzi³a (?) p³at potyliczny. Jaki zmys³ móg³ ucierpieæ?", 20);

//                    answers.Add(new Answer(answer_A_button, "wzrok", true));
//                    answers.Add(new Answer(answer_B_button, "s³uch", false));
//                    answers.Add(new Answer(answer_C_button, "mowa", false));
//                    answers.Add(new Answer(answer_D_button, "wêch", false));
//                    updateTextElementOnScreen(answers);

//                    enterOnceInUpdate = true;
//                    //goToResumeButton.interactable = true;
//                    buttonGoToResume.SetActive(true);
//                    buttonNextQuestion.SetActive(false);
//                }
//                break;
//        }
//    }

//    public void printTextElementOnScreen(Button answer, string text = "", int x = -426, int y = 39, int fontSize = 47)
//    {
//        Text textPrefab = answer.GetComponentInChildren<Text>();
//        Text newText = Instantiate(textPrefab, transform);
//        newText.text = text;
//        newText.color = Color.white;
//        newText.fontSize = fontSize;
//        RectTransform rectTransform = newText.GetComponent<RectTransform>();
//        rectTransform.anchoredPosition = new Vector2(x, y);
//    }

//    public void printTextElementOnScreen(Text answer, string text = "", int x = -426, int y = 39, int fontSize = 47)
//    {
//        Text newText = Instantiate(answer, transform);
//        newText.text = text;
//        newText.color = Color.white;
//        newText.fontSize = fontSize;
//        RectTransform rectTransform = newText.GetComponent<RectTransform>();
//        rectTransform.anchoredPosition = new Vector2(x, y);
//    }

//    public void updateTextElementOnScreen(List<Answer> answers)
//    {
//        foreach (var answer in answers)
//        {
//            if (answer.isButtonActive)
//            {
//                answer.answerButton.interactable = true;
//            }
//            else
//            {
//                answer.answerButton.interactable = false;
//            }
//            answer.answerCorectnessHandler(answers);
//            answer.answerButton.GetComponentInChildren<Text>().text = answer.answerText;
//        }
//    }

//    public void updateTextElementOnScreen(Text answer, string text, int fontSize = 47, bool isButtonActive = true)
//    {
//        answer.GetComponentInChildren<Text>().text = text;
//        answer.GetComponentInChildren<Text>().fontSize = fontSize;
//    }

//    public void nextQuestion()
//    {
//        currentQuestionNumber++;
//        enterOnceInUpdate = false;

//        foreach (var answer in answers)
//        {
//            answer.resetEverything();
//        }
//        answers.RemoveRange(0, 4);
//    }

//}

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

    public GameObject buttonGoToResume;
    public GameObject buttonNextQuestion;

    void Start()
    {
        //goToResumeButton.interactable = false;
        buttonGoToResume.SetActive(false);
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
                    updateTextElementOnScreen(question, "Który p³at mózgowy nie istnieje?");
                    answers.Add(new Answer(answer_A_button, "czo³owy", false));
                    answers.Add(new Answer(answer_B_button, "polityczny", true));
                    answers.Add(new Answer(answer_C_button, "skroniowy", false));
                    answers.Add(new Answer(answer_D_button, "ciemieniowy", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 2:
                if (!enterOnceInUpdate)
                {
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, "Lewa pó³kula odpowiada za:");

                    answers.Add(new Answer(answer_A_button, "logikê", true));
                    answers.Add(new Answer(answer_B_button, "kreatywnoœæ", false));
                    answers.Add(new Answer(answer_C_button, "-", false, false));
                    answers.Add(new Answer(answer_D_button, "-", false, false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 3:
                if (!enterOnceInUpdate)
                {
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, "Osoba uderzy³a siê mocno w ty³ g³owy, i uszkodzi³a (?) p³at potyliczny. Jaki zmys³ móg³ ucierpieæ?", 20);

                    answers.Add(new Answer(answer_A_button, "wzrok", true));
                    answers.Add(new Answer(answer_B_button, "s³uch", false));
                    answers.Add(new Answer(answer_C_button, "mowa", false));
                    answers.Add(new Answer(answer_D_button, "wêch", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                    //goToResumeButton.interactable = true;
                    buttonGoToResume.SetActive(true);
                    buttonNextQuestion.SetActive(false);
                }
                break;
        }
    }

    public void answerCorrectnessHandler(Answer answer)
    {
        if (answer.isAnswerCorrect)
        {
            answer.answerButton.onClick.AddListener(() => correctAnswerHandler(answer));

        }
        else
        {
            answer.answerButton.onClick.AddListener(() => wrongAnswerHandler(answer));
        }
    }

    public void removeButtonListener(Answer answer)
    {
        answer.answerButton.onClick.RemoveAllListeners();
    }

    public void correctAnswerHandler(Answer answer)
    {
        Timer.StopTimer();
        timeScore = Timer.GetElapsedTimeInSeconds();
        score += Timer.calculateTimeToPoints();
        answer.answerButton.image.color = Color.green;

        foreach (var answer2 in answers)
        {
            if (!answer.isAnswerCorrect)
            {
                answer2.answerButton.interactable = false;
            }
        }
    }

    public void wrongAnswerHandler(Answer answer)
    {
        answer.answerButton.image.color = Color.red;
    }

    public void resetEverything(Answer answer)
    {
        removeButtonListener(answer);
        answer.answerButton.image.color = Color.white;
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

    public void updateTextElementOnScreen()
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
            answerCorrectnessHandler(answer);
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
            resetEverything(answer);
        }
        answers.RemoveRange(0, 4);
    }

}