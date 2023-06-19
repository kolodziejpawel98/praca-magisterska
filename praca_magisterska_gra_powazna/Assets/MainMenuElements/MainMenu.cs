using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void nextScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void previousScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void goToNeuron()
    {
        SceneManager.LoadScene(9);
    }

    public void goToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void goToBrain()
    {
        SceneManager.LoadScene(2);
    }

    public void goToTest()
    {
        SceneManager.LoadScene(6);
    }

    public void goToSceneMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void goToSceneBrainPolkole()
    {
        SceneManager.LoadScene(2);
    }

    public void goToSceneBrainPlaty()
    {
        SceneManager.LoadScene(3);
    }

    public void goToSceneBrainPrzekroj()
    {
        SceneManager.LoadScene(4);
    }

    public void goToSceneMenuTestLearn()
    {
        SceneManager.LoadScene(5);
    }

    public void goToSceneTestTutorial()
    {
        SceneManager.LoadScene(6);
    }

    public void goToSceneTest()
    {
        SceneManager.LoadScene(7);
    }

    public void goToSceneScoreTable()
    {
        SceneManager.LoadScene(8);
    }

    public void goToSceneNeuron()
    {
        SceneManager.LoadScene(9);
    }

    public void goToScenePrzekazywanieImpulsu()
    {
        SceneManager.LoadScene(10);
    }

    public void goToSceneNeuronObwoluta()
    {
        SceneManager.LoadScene(11);
    }

    public void goToScenePompa()
    {
        SceneManager.LoadScene(12);
    }

    public void goToScenePotencjal()
    {
        SceneManager.LoadScene(13);
    }

}
