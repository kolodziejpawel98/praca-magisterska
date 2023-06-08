using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTutorial : MonoBehaviour
{
    public List<GameObject> tutorialSteps = new List<GameObject>();
    private int currentStepIndex = 0;

    public void Update()
    {
        tutorialSteps[currentStepIndex].SetActive(true);
    }

    public void nextTutorialStep()
    {
        p.r("!!!!!!!!!!!!!!!!!!!!!");
        tutorialSteps[currentStepIndex].SetActive(false);
        currentStepIndex++;
    }
}
