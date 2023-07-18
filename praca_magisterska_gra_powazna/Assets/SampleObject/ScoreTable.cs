using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTable : MonoBehaviour
{
    public InputHandler inputHandler;

    public GameObject congratulationText;
    public GameObject congratulationTrophy;


    public GameObject prefabPlayerName;
    public GameObject prefabPlayerScore;
    public GameObject pointScoreTableFirstPlace;

    void Start()
    {
        updateCurrentPlayerScore();
        if (getCurrentPlayerIndex() > 9)
        {
            printTopTenPlayersWithoutCurrentPlayer();
            printCurrentPlayerOnSide();
        }
        else
        {
            if(getCurrentPlayerIndex() == 0)
            {
                congratulationText.SetActive(true);
                congratulationTrophy.SetActive(true);
            }
            printTopTenPlayersWithCurrentPlayer();
        }
    }

    public void printTopTenPlayersWithoutCurrentPlayer()
    {
        int scoreRowPositionCounter = 10;
        int topTenPlayersCounter = 0;

        foreach (var player in inputHandler.players)
        {
            GameObject playerNameText = Instantiate(prefabPlayerName, transform);
            GameObject playerNameScore = Instantiate(prefabPlayerScore, transform);

            playerNameText.transform.position = new Vector3(280, pointScoreTableFirstPlace.transform.position.y - scoreRowPositionCounter, 0);
            playerNameText.GetComponent<Text>().text = player.playerName;
            playerNameScore.transform.position = new Vector3(780, pointScoreTableFirstPlace.transform.position.y - scoreRowPositionCounter, 0);
            playerNameScore.GetComponent<Text>().text = player.points.ToString();
            scoreRowPositionCounter += 40;
            topTenPlayersCounter++;

            if (topTenPlayersCounter == 9)
            {
                break;
            }
        }
    }

    public void printCurrentPlayerOnSide()
    {
        GameObject playerNameText = Instantiate(prefabPlayerName, transform);
        GameObject playerNameScore = Instantiate(prefabPlayerScore, transform);

        playerNameText.GetComponent<Text>().color = Color.black;
        playerNameScore.GetComponent<Text>().color = Color.black;

        playerNameText.transform.position = new Vector3(980, 400, 0);
        playerNameText.GetComponent<Text>().text = "Niestety, Twój wynik nie kwalifikuje siê do najlepszej 10tki\n" + inputHandler.players[getCurrentPlayerIndex()].playerName;
        playerNameScore.transform.position = new Vector3(1280, 400, 0);
        playerNameScore.GetComponent<Text>().text = "\n\n" + inputHandler.players[getCurrentPlayerIndex()].points.ToString();
    }

    public void printTopTenPlayersWithCurrentPlayer()
    {
        int scoreRowPositionCounter = 10;
        int topTenPlayersCounter = 0;

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
            topTenPlayersCounter++;

            if (topTenPlayersCounter == 9)
            {
                break;
            }
        }
    }

    public int getCurrentPlayerIndex()
    {
        int index = 0;
        foreach (var player in inputHandler.players)
        {
            if (player.isCurrentPlayer)
            {
                return index;
            }
            index++;
        }
        return -1;
    }

    public void updateCurrentPlayerScore()
    {
        //update'uje legitnym wynikiem pole points gracza, ktore przy tworzeniu zostal wypelniny losowa wartoscia
        foreach (var player in inputHandler.players)
        {
            if (player.isCurrentPlayer)
            {
                player.points = TestBackend.score;
                inputHandler.sortPlayers();
                inputHandler.SaveToJSON(inputHandler.players);
            }
        }
    }



}
