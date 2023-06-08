using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTutorial : MonoBehaviour
{
    public List<GameObject> tutorialSteps = new List<GameObject>();
    private int currentStepIndex = 0;
    public GameObject buttonNextStep;
    public GameObject buttonGoToTest;

    private void Start()
    {
        buttonGoToTest.SetActive(false);
    }

    public void Update()
    {
        tutorialSteps[currentStepIndex].SetActive(true);

        if(currentStepIndex == 7)
        {
            buttonGoToTest.SetActive(true);
            buttonNextStep.SetActive(false);
        }
    }

    public void nextTutorialStep()
    {
        p.r("!!!!!!!!!!!!!!!!!!!!!");
        tutorialSteps[currentStepIndex].SetActive(false);
        currentStepIndex++;
    }
}
