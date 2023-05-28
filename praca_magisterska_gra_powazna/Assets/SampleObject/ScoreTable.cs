using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTable : MonoBehaviour
{
    public InputHandler inputHandler;


    public GameObject prefabPlayerName;
    public GameObject prefabPlayerScore;
    public GameObject pointScoreTableFirstPlace;

    void Start()
    {
        printPlayerScore();   
    }

    public void printPlayerScore()
    {
        int scoreRowPositionCounter = 10;
        foreach (var player in inputHandler.players)
        {
            GameObject playerNameText = Instantiate(prefabPlayerName, transform);
            GameObject playerNameScore = Instantiate(prefabPlayerScore, transform);
            
            if (player.isCurrentPlayer)
            {
                playerNameText.GetComponent<Text>().color = Color.yellow;
                playerNameScore.GetComponent<Text>().color = Color.yellow;
            }
            
            playerNameText.transform.position = new Vector3(280, pointScoreTableFirstPlace.transform.position.y - scoreRowPositionCounter, 0);
            playerNameText.GetComponent<Text>().text = player.playerName;
            playerNameScore.transform.position = new Vector3(780, pointScoreTableFirstPlace.transform.position.y - scoreRowPositionCounter, 0);
            playerNameScore.GetComponent<Text>().text = player.points.ToString();
            scoreRowPositionCounter += 40;
        }
    }
}
