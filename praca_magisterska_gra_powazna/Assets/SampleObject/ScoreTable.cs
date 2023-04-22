using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTable : MonoBehaviour
{
    public InputHandler inputHandler;


    public GameObject prefabPlayerName;
    public GameObject prefabPlayerScore;

    void Start()
    {
        printPlayerScore();   
    }

    public void printPlayerScore()
    {
        int scoreCounter = 0;
        foreach (var player in inputHandler.players)
        {
            GameObject playerNameText = Instantiate(prefabPlayerName, transform);
            GameObject playerNameScore = Instantiate(prefabPlayerScore, transform);
            playerNameText.transform.position = new Vector3(250, scoreCounter * 100, 0);
            playerNameText.GetComponent<Text>().text = player.playerName;
            playerNameScore.transform.position = new Vector3(550, scoreCounter * 100, 0);
            playerNameScore.GetComponent<Text>().text = player.points.ToString();
            scoreCounter++;
        }
    }
}
