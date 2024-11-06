using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player
{
    public string playerName = "";
    public int health;
    private static int playerCount = 0;

    public void InitializePlayer(string name, int h)
    {
        playerName = name;
        health = checkHealth(h);
        playerCount++;
    }


    public void heal(int amount)
    {
        health = checkHealth(health += amount);
        Debug.Log("the new healt is " + health);
    }

    public void heal(bool fullRestore)
    {
        if (fullRestore == true)
        {
            health = 100;
            Debug.Log("healt after full restore is " + health);
        }
    }

    public static void ShowPlayerCount()
    {
        Debug.Log("the number of players is " + playerCount);
    }

    static int checkHealth(int healing)
    {
        if (healing >= 100)
        {
            healing = 100;
        }
        return healing;
    }

}
