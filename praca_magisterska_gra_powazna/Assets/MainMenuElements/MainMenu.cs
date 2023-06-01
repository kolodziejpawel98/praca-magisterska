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
        SceneManager.LoadScene(8);
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
}
