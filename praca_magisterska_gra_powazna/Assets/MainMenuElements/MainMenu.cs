using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    ZoomMouseWheel zoomMouseWheel;
    BrainCentralization brainCentralization;
    BrainRotation brainRotation;
    GrabRotation grabRotation;
    MoveAnimation moveAnimation;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GoInside()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        resetAllVariables();
        //TODO:
        //dodac metode ktora bedzie zerowala wsyztskie zmienne po zmianie sceny z polkule na platy
    }

    void resetAllVariables()
    {
        zoomMouseWheel.resetVariables();
        brainCentralization.resetVariables();
        brainRotation.resetVariables();
        grabRotation.resetVariables();
        moveAnimation.resetVariables();
    }
}
