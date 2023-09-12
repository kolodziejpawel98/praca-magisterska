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

    public static int currentQuestionNumber = 1;
    public static bool isBrainTestChoosen = false;
    public static bool isNeuronTestChoosen = false;
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
        buttonNextQuestion.SetActive(false);
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
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Kt�ry p�at m�zgowy nie istnieje?", 30);
                    answers.Add(new Answer(answer_A_button, "czo�owy", false));
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
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Lewa p�kula odpowiada za:", 30);

                    answers.Add(new Answer(answer_A_button, "logik�", true));
                    answers.Add(new Answer(answer_B_button, "kreatywno��", false));
                    answers.Add(new Answer(answer_C_button, "trawienie", false));
                    answers.Add(new Answer(answer_D_button, "funkcjonowanie lewej strony cia�a", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 3:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Ukszta�towany ewolucyjnie jako jeden z ostatnich:", 30);

                    answers.Add(new Answer(answer_A_button, "m�d�ek", false));
                    answers.Add(new Answer(answer_B_button, "most", false));
                    answers.Add(new Answer(answer_C_button, "p�at czo�owy", true));
                    answers.Add(new Answer(answer_D_button, "p�at skroniowy", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 4:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pomijaj�c wiele innych problem�w, gdyby� straci�/a nagle ten p�at, nie b�dziesz w stanie rozpozna� twarzy:", 30);

                    answers.Add(new Answer(answer_A_button, "potyliczny", false));
                    answers.Add(new Answer(answer_B_button, "skroniowy", true));
                    answers.Add(new Answer(answer_C_button, "czo�owy", false));
                    answers.Add(new Answer(answer_D_button, "ciemieniowy", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 5:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Jeste� w obcym miejscu. Za zorientowanie si� w przestrzeni b�dzie odpowiada�/o:", 30);

                    answers.Add(new Answer(answer_A_button, "p�at wzrokowy", false));
                    answers.Add(new Answer(answer_B_button, "kresom�zgowie", false));
                    answers.Add(new Answer(answer_C_button, "m�d�ek", false));
                    answers.Add(new Answer(answer_D_button, "p�at ciemieniowy", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 6:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Posiada bardzo g�sty zbi�r kom�rek nerwowych:", 30);

                    answers.Add(new Answer(answer_A_button, "m�d�ek", true));
                    answers.Add(new Answer(answer_B_button, "most", false));
                    answers.Add(new Answer(answer_C_button, "pie�", false));
                    answers.Add(new Answer(answer_D_button, "hipokamp", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 7:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pe�ni funkcj� po�rednika mi�dzy ma�ym palcem stopy a neuronami w m�zgu:", 30);

                    answers.Add(new Answer(answer_A_button, "istota szara", false));
                    answers.Add(new Answer(answer_B_button, "pas skroniowy", false));
                    answers.Add(new Answer(answer_C_button, "neuron przewodnikowy", false));
                    answers.Add(new Answer(answer_D_button, "pie�", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 8:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Hipokamp jest odpowiedzialny za:", 30);

                    answers.Add(new Answer(answer_A_button, "snucie hipotez", false));
                    answers.Add(new Answer(answer_B_button, "pami��", true));
                    answers.Add(new Answer(answer_C_button, "wzrok", false));
                    answers.Add(new Answer(answer_D_button, "sen", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 9:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Odpowiada za sen: ___, i znajduje si� w: ___", 30);

                    answers.Add(new Answer(answer_A_button, "Istota szara, m�d�ek", false));
                    answers.Add(new Answer(answer_B_button, "Istota szara, rdze� przed�u�ony", false));
                    answers.Add(new Answer(answer_C_button, "Szyszynka, �r�dm�zgowie", false));
                    answers.Add(new Answer(answer_D_button, "Szyszynka, mi�dzym�zgowie", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 10:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Odpowiada za pami��: ___, i znajduje si� w: ___", 30);

                    answers.Add(new Answer(answer_A_button, "Istota czarna, �r�dm�gowie", true));
                    answers.Add(new Answer(answer_B_button, "Istota czarna, rdze� przed�u�ony", false));
                    answers.Add(new Answer(answer_C_button, "Istota szara, �r�dm�zgowie", false));
                    answers.Add(new Answer(answer_D_button, "Istota szara, mi�dzym�zgowie", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 11:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Odpowiedzialny za wywo�anie wymiot�w", 30);

                    answers.Add(new Answer(answer_A_button, "O�rodek wymiotowania w rdzeniu przed�u�onym", true));
                    answers.Add(new Answer(answer_B_button, "O�rodek wymiotowania w m�d�ku", false));
                    answers.Add(new Answer(answer_C_button, "O�rodek wymiotowania w p�acie potyliczym", false));
                    answers.Add(new Answer(answer_D_button, "O�rodek wymiotowania w rdzeniu �o��dkowym", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 12:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Osoba uderzy�a si� mocno w ty� g�owy, i uszkodzi�a p�at potyliczny. Jaki zmys� m�g� ucierpie�?", 30);

                    answers.Add(new Answer(answer_A_button, "wzrok", true));
                    answers.Add(new Answer(answer_B_button, "s�uch", false));
                    answers.Add(new Answer(answer_C_button, "mowa", false));
                    answers.Add(new Answer(answer_D_button, "w�ch", false));
                    if (isBrainTestChoosen)
                    {
                        updateTextElementOnScreen(true);
                    }
                    else
                    {
                        updateTextElementOnScreen();
                    }
                    

                    enterOnceInUpdate = true;
                }
                break;
            case 13:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Rol� anten zbieraj�cych sygna� pe�ni�:", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber-12).ToString() + ". Rol� anten zbieraj�cych sygna� pe�ni�:", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "synapsy", false));
                    answers.Add(new Answer(answer_B_button, "mieliny", false));
                    answers.Add(new Answer(answer_C_button, "aksony", false));
                    answers.Add(new Answer(answer_D_button, "dendryty", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 14:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Zajmuje sie mi�dzy innymi integracj� sygna��w otrzymanych z dendryt�w", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Zajmuje sie mi�dzy innymi integracj� sygna��w otrzymanych z dendryt�w", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "cia�o kom�rki", true));
                    answers.Add(new Answer(answer_B_button, "akson", false));
                    answers.Add(new Answer(answer_C_button, "drzewko ko�cowe", false));
                    answers.Add(new Answer(answer_D_button, "wypustka Schwanna", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 15:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pe�ni funkcj� izolacji aksonu", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Pe�ni funkcj� izolacji aksonu", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "os�onka synaptyczna", false));
                    answers.Add(new Answer(answer_B_button, "j�dro", false));
                    answers.Add(new Answer(answer_C_button, "os�onka mielinowa", true));
                    answers.Add(new Answer(answer_D_button, "cia�o kom�rki", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 16:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Przerwania w os�once mielinowej nazywamy", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Przerwania w os�once mielinowej nazywamy", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "w�z��mi Ranviera", true));
                    answers.Add(new Answer(answer_B_button, "przerwaniami skokowymi", false));
                    answers.Add(new Answer(answer_C_button, "szczelinami synaptycznymi", false));
                    answers.Add(new Answer(answer_D_button, "zw�eniami kom�rkowymi", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 17:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pe�ni rol� przeka�nika sygna�u do innych neuron�w", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Pe�ni rol� przeka�nika sygna�u do innych neuron�w", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "j�dro", false));
                    answers.Add(new Answer(answer_B_button, "dendryt", false));
                    answers.Add(new Answer(answer_C_button, "drzewko ko�cowe", true));
                    answers.Add(new Answer(answer_D_button, "akson", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 18:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Wn�trze neuronu w stanie spoczynku jest na�adowane", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Wn�trze neuronu w stanie spoczynku jest na�adowane", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "ujemnie", true));
                    answers.Add(new Answer(answer_B_button, "dodatnio", false));
                    answers.Add(new Answer(answer_C_button, "nie jest na�adowane w og�le", false));
                    answers.Add(new Answer(answer_D_button, "naprzemiennie ujemnie i dodatnio", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 19:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pompa sodowo-potasowa dzia�a dzi�ki naturalnemu paliwu o nazwie", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Pompa sodowo-potasowa dzia�a dzi�ki naturalnemu paliwu o nazwie", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "kwas potasowy", false));
                    answers.Add(new Answer(answer_B_button, "kwas bia�kowy", false));
                    answers.Add(new Answer(answer_C_button, "RNA", false));
                    answers.Add(new Answer(answer_D_button, "ATP", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 20:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pompa sodowo-potasowa przekazuje jony sodu na ____, a jony potasu na ____", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Pompa sodowo-potasowa przekazuje jony sodu na ____, a jony potasu na ____", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "zewn�trz, wewn�trz", true));
                    answers.Add(new Answer(answer_B_button, "wewn�trz, zewn�trz", false));
                    answers.Add(new Answer(answer_C_button, "jony potasu i sodu s� przekazywane razem na zewn�trz", false));
                    answers.Add(new Answer(answer_D_button, "jony potasu i sodu s� przekazywane razem na zewn�trz", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 21:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Neuron mo�e przekazywa� impuls elektryczny do kolejnych neuron�w dzi�ki", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Neuron mo�e przekazywa� impuls elektryczny do kolejnych neuron�w dzi�ki", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "zmianie napi�cia na ujemne", false));
                    answers.Add(new Answer(answer_B_button, "zmianie napi�cia na dodatnie", true));
                    answers.Add(new Answer(answer_C_button, "zjawisku indukcji", false));
                    answers.Add(new Answer(answer_D_button, "zjawisku perforacji b�ony kom�rkowej", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 22:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Potencja� czynnosciowy to inaczej:", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Potencja� czynnosciowy to inaczej:", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "miara plastyczno�ci neuronu", false));
                    answers.Add(new Answer(answer_B_button, "zdolno�� do zmiany po�o�enia", false));
                    answers.Add(new Answer(answer_C_button, "gotowo�� neuronu do wykonania pracy w jednostce czasu", false));
                    answers.Add(new Answer(answer_D_button, "impuls elektryczny s�u��cy do komunikacji z innymi neuronami", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 23:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Neuron jest w stanie spoczynku przy napi�ciu wynosz�cym oko�o", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Neuron jest w stanie spoczynku przy napi�ciu wynosz�cym oko�o", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "-70mV", true));
                    answers.Add(new Answer(answer_B_button, "-700mV", false));
                    answers.Add(new Answer(answer_C_button, "700mV", false));
                    answers.Add(new Answer(answer_D_button, "0.07mV", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;

            case 24:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    if (!isNeuronTestChoosen)
                    {
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Hiperpolaryzacja to", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Hiperpolaryzacja to", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "spadek napi�cia poni�ej stanu spoczynku", true));
                    answers.Add(new Answer(answer_B_button, "wzrost napi�cia powy�ej stanu spoczynku", false));
                    answers.Add(new Answer(answer_C_button, "naprzemienna zmiana napi�cia w jednostce czasu", false));
                    answers.Add(new Answer(answer_D_button, "stan odwrotnego reagowania na sygna�y", false));
                    updateTextElementOnScreen(true);

                    enterOnceInUpdate = true;
                }
                break;
        }
    }

    public void resetScore()
    {
        p.r("score = " + score);
        score = 0.0f;
    }

    public void answerCorrectnessHandler(Answer answer, bool isLastQuestion)
    {
        if (answer.isAnswerCorrect)
        {
            answer.answerButton.onClick.AddListener(() => correctAnswerHandler(answer, isLastQuestion));

        }
        else
        {
            answer.answerButton.onClick.AddListener(() => wrongAnswerHandler(answer, isLastQuestion));
        }
    }

    public void removeButtonListener(Answer answer)
    {
        answer.answerButton.onClick.RemoveAllListeners();
    }

    public void correctAnswerHandler(Answer answer, bool isLastQuestion)
    {
        Timer.StopTimer();
        timeScore = Timer.GetElapsedTimeInSeconds();
        score += Timer.calculateTimeToPoints();
        answer.answerButton.image.color = Color.green;

        foreach (var answer2 in answers)
        {
            if (!answer2.isAnswerCorrect)
            {
                answer2.answerButton.interactable = false;
            }
        }

        if (isLastQuestion)
        {
            buttonGoToResume.SetActive(true);
        }
        else
        {
            buttonNextQuestion.SetActive(true);
        }

    }

    public void wrongAnswerHandler(Answer wrongAnswer, bool isLastQuestion)
    {
        foreach (var answer in answers)
        {
            answer.answerButton.interactable = false;
        }

        wrongAnswer.answerButton.image.color = Color.red;
        wrongAnswer.answerButton.interactable = true;

        if (isLastQuestion)
        {
            buttonGoToResume.SetActive(true);
        }
        else
        {
            buttonNextQuestion.SetActive(true);
        }
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

    public void updateTextElementOnScreen(bool isLastQuestion = false)
    {
        p.r("is last question = " + isLastQuestion);
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
            answerCorrectnessHandler(answer, isLastQuestion);
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