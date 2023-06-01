using System;

[Serializable]
public class Player
{
    public string playerName;
    public float points;
    public bool isCurrentPlayer;

    public Player(string name, int points, bool isCurrentPlayer)
    {
        playerName = name;
        this.points = points;
        this.isCurrentPlayer = isCurrentPlayer;
    }
}