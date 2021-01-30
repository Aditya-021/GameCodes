using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]// ****Now we can able to save it as a file.
public class PlayerData 
{
    public int health;
    public int points;

    public PlayerData(Player player)
    {
        health = player.health;
        points = player.points;
    }
}
