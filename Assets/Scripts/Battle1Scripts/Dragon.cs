using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : Monster{
    private int hp;
    private int spd;
    
    public Dragon(int health, int speed)
    {
        hp = health;
        spd = speed;
    }

    public override Monster clone()
    {
        Debug.Log("I'm a dragon!");
        return new Dragon(hp, spd);
    }
}