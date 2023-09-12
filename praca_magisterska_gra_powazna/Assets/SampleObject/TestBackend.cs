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
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Który p³at mózgowy nie istnieje?", 30);
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
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Lewa pó³kula odpowiada za:", 30);

                    answers.Add(new Answer(answer_A_button, "logikê", true));
                    answers.Add(new Answer(answer_B_button, "kreatywnoœæ", false));
                    answers.Add(new Answer(answer_C_button, "trawienie", false));
                    answers.Add(new Answer(answer_D_button, "funkcjonowanie lewej strony cia³a", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 3:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Ukszta³towany ewolucyjnie jako jeden z ostatnich:", 30);

                    answers.Add(new Answer(answer_A_button, "mó¿d¿ek", false));
                    answers.Add(new Answer(answer_B_button, "most", false));
                    answers.Add(new Answer(answer_C_button, "p³at czo³owy", true));
                    answers.Add(new Answer(answer_D_button, "p³at skroniowy", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 4:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pomijaj¹c wiele innych problemów, gdybyœ straci³/a nagle ten p³at, nie bêdziesz w stanie rozpoznaæ twarzy:", 30);

                    answers.Add(new Answer(answer_A_button, "potyliczny", false));
                    answers.Add(new Answer(answer_B_button, "skroniowy", true));
                    answers.Add(new Answer(answer_C_button, "czo³owy", false));
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
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Jesteœ w obcym miejscu. Za zorientowanie siê w przestrzeni bêdzie odpowiada³/o:", 30);

                    answers.Add(new Answer(answer_A_button, "p³at wzrokowy", false));
                    answers.Add(new Answer(answer_B_button, "kresomózgowie", false));
                    answers.Add(new Answer(answer_C_button, "mó¿d¿ek", false));
                    answers.Add(new Answer(answer_D_button, "p³at ciemieniowy", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 6:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Posiada bardzo gêsty zbiór komórek nerwowych:", 30);

                    answers.Add(new Answer(answer_A_button, "mó¿d¿ek", true));
                    answers.Add(new Answer(answer_B_button, "most", false));
                    answers.Add(new Answer(answer_C_button, "pieñ", false));
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
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pe³ni funkcjê poœrednika miêdzy ma³ym palcem stopy a neuronami w mózgu:", 30);

                    answers.Add(new Answer(answer_A_button, "istota szara", false));
                    answers.Add(new Answer(answer_B_button, "pas skroniowy", false));
                    answers.Add(new Answer(answer_C_button, "neuron przewodnikowy", false));
                    answers.Add(new Answer(answer_D_button, "pieñ", true));
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
                    answers.Add(new Answer(answer_B_button, "pamiêæ", true));
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
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Odpowiada za sen: ___, i znajduje siê w: ___", 30);

                    answers.Add(new Answer(answer_A_button, "Istota szara, mó¿d¿ek", false));
                    answers.Add(new Answer(answer_B_button, "Istota szara, rdzeñ przed³u¿ony", false));
                    answers.Add(new Answer(answer_C_button, "Szyszynka, œródmózgowie", false));
                    answers.Add(new Answer(answer_D_button, "Szyszynka, miêdzymózgowie", true));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 10:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Odpowiada za pamiêæ: ___, i znajduje siê w: ___", 30);

                    answers.Add(new Answer(answer_A_button, "Istota czarna, œródmó¿gowie", true));
                    answers.Add(new Answer(answer_B_button, "Istota czarna, rdzeñ przed³u¿ony", false));
                    answers.Add(new Answer(answer_C_button, "Istota szara, œródmózgowie", false));
                    answers.Add(new Answer(answer_D_button, "Istota szara, miêdzymózgowie", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 11:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Odpowiedzialny za wywo³anie wymiotów", 30);

                    answers.Add(new Answer(answer_A_button, "Oœrodek wymiotowania w rdzeniu przed³u¿onym", true));
                    answers.Add(new Answer(answer_B_button, "Oœrodek wymiotowania w mó¿d¿ku", false));
                    answers.Add(new Answer(answer_C_button, "Oœrodek wymiotowania w p³acie potyliczym", false));
                    answers.Add(new Answer(answer_D_button, "Oœrodek wymiotowania w rdzeniu ¿o³¹dkowym", false));
                    updateTextElementOnScreen();

                    enterOnceInUpdate = true;
                }
                break;
            case 12:
                if (!enterOnceInUpdate)
                {
                    buttonNextQuestion.SetActive(false);
                    Timer.StartTimer();
                    updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Osoba uderzy³a siê mocno w ty³ g³owy, i uszkodzi³a p³at potyliczny. Jaki zmys³ móg³ ucierpieæ?", 30);

                    answers.Add(new Answer(answer_A_button, "wzrok", true));
                    answers.Add(new Answer(answer_B_button, "s³uch", false));
                    answers.Add(new Answer(answer_C_button, "mowa", false));
                    answers.Add(new Answer(answer_D_button, "wêch", false));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Rolê anten zbieraj¹cych sygna³ pe³ni¹:", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber-12).ToString() + ". Rolê anten zbieraj¹cych sygna³ pe³ni¹:", 30);
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Zajmuje sie miêdzy innymi integracj¹ sygna³ów otrzymanych z dendrytów", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Zajmuje sie miêdzy innymi integracj¹ sygna³ów otrzymanych z dendrytów", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "cia³o komórki", true));
                    answers.Add(new Answer(answer_B_button, "akson", false));
                    answers.Add(new Answer(answer_C_button, "drzewko koñcowe", false));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pe³ni funkcjê izolacji aksonu", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Pe³ni funkcjê izolacji aksonu", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "os³onka synaptyczna", false));
                    answers.Add(new Answer(answer_B_button, "j¹dro", false));
                    answers.Add(new Answer(answer_C_button, "os³onka mielinowa", true));
                    answers.Add(new Answer(answer_D_button, "cia³o komórki", false));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Przerwania w os³once mielinowej nazywamy", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Przerwania w os³once mielinowej nazywamy", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "wêz³¹mi Ranviera", true));
                    answers.Add(new Answer(answer_B_button, "przerwaniami skokowymi", false));
                    answers.Add(new Answer(answer_C_button, "szczelinami synaptycznymi", false));
                    answers.Add(new Answer(answer_D_button, "zwê¿eniami komórkowymi", false));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pe³ni rolê przekaŸnika sygna³u do innych neuronów", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Pe³ni rolê przekaŸnika sygna³u do innych neuronów", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "j¹dro", false));
                    answers.Add(new Answer(answer_B_button, "dendryt", false));
                    answers.Add(new Answer(answer_C_button, "drzewko koñcowe", true));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Wnêtrze neuronu w stanie spoczynku jest na³adowane", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Wnêtrze neuronu w stanie spoczynku jest na³adowane", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "ujemnie", true));
                    answers.Add(new Answer(answer_B_button, "dodatnio", false));
                    answers.Add(new Answer(answer_C_button, "nie jest na³adowane w ogóle", false));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Pompa sodowo-potasowa dzia³a dziêki naturalnemu paliwu o nazwie", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Pompa sodowo-potasowa dzia³a dziêki naturalnemu paliwu o nazwie", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "kwas potasowy", false));
                    answers.Add(new Answer(answer_B_button, "kwas bia³kowy", false));
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

                    answers.Add(new Answer(answer_A_button, "zewn¹trz, wewn¹trz", true));
                    answers.Add(new Answer(answer_B_button, "wewn¹trz, zewn¹trz", false));
                    answers.Add(new Answer(answer_C_button, "jony potasu i sodu s¹ przekazywane razem na zewn¹trz", false));
                    answers.Add(new Answer(answer_D_button, "jony potasu i sodu s¹ przekazywane razem na zewn¹trz", false));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Neuron mo¿e przekazywaæ impuls elektryczny do kolejnych neuronów dziêki", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Neuron mo¿e przekazywaæ impuls elektryczny do kolejnych neuronów dziêki", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "zmianie napiêcia na ujemne", false));
                    answers.Add(new Answer(answer_B_button, "zmianie napiêcia na dodatnie", true));
                    answers.Add(new Answer(answer_C_button, "zjawisku indukcji", false));
                    answers.Add(new Answer(answer_D_button, "zjawisku perforacji b³ony komórkowej", false));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Potencja³ czynnosciowy to inaczej:", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Potencja³ czynnosciowy to inaczej:", 30);
                    }

                    answers.Add(new Answer(answer_A_button, "miara plastycznoœci neuronu", false));
                    answers.Add(new Answer(answer_B_button, "zdolnoœæ do zmiany po³o¿enia", false));
                    answers.Add(new Answer(answer_C_button, "gotowoœæ neuronu do wykonania pracy w jednostce czasu", false));
                    answers.Add(new Answer(answer_D_button, "impuls elektryczny s³u¿¹cy do komunikacji z innymi neuronami", true));
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
                        updateTextElementOnScreen(question, currentQuestionNumber.ToString() + ". Neuron jest w stanie spoczynku przy napiêciu wynosz¹cym oko³o", 30);
                    }
                    else
                    {
                        //currentQuestionNumber = 1;
                        updateTextElementOnScreen(question, (currentQuestionNumber - 12).ToString() + ". Neuron jest w stanie spoczynku przy napiêciu wynosz¹cym oko³o", 30);
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

                    answers.Add(new Answer(answer_A_button, "spadek napiêcia poni¿ej stanu spoczynku", true));
                    answers.Add(new Answer(answer_B_button, "wzrost napiêcia powy¿ej stanu spoczynku", false));
                    answers.Add(new Answer(answer_C_button, "naprzemienna zmiana napiêcia w jednostce czasu", false));
                    answers.Add(new Answer(answer_D_button, "stan odwrotnego reagowania na sygna³y", false));
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