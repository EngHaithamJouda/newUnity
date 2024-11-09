using System;
using UnityEngine;

public class Player1 : Character
{
    public Player1(string name, int health) : base(name, health)
    {
    }

    public void Heal(int amount)
    {
        Health += Math.Abs(amount);
        Debug.Log(Name + " is healed by " + amount + ". The new Health is: " + Health);
    }

}
