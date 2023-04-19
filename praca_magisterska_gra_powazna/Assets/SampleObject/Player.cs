using System;

[Serializable]
public class Player
{
    public string playerName;
    public int points;

    public Player(string name, int points)
    {
        playerName = name;
        this.points = points;
    }
}