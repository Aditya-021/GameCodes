using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int points;

   /* private void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            SavePlayer();
        }
        if(Input.GetKey(KeyCode.L))
        {
            LoadPlayer();
        }

        if (Input.GetKey(KeyCode.A))
        {
            health += 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            points += 1;
        }
    }*/

    public void SavePlayer()
    {
        SaveData.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData data = SaveData.LoadPlayer();
        health = data.health;
        points = data.points;
    }
}
