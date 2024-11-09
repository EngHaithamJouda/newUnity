using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{

    public Enemy(string name, int health) : base(name, health)
    {
    }

    public void Attack(Character target, int damage)
    {
        damage = Math.Abs(damage);
        if (target.Health <= Math.Abs(damage))
        {
            target.Health = 0;
        }
        else
        {
            target.Health -= Math.Abs(damage);
        }
        Debug.Log(Name + " attacked " + target.Name + " with damage " + damage + ". " + target.Name + " Health: " + target.Health);
    }



}
