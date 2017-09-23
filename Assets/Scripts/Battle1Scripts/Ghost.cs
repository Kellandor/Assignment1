using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Monster
{
    private int hp;
    private int spd;

    public Ghost(int health, int speed)
    {
        hp = health;
        spd = speed;
    }

    public override Monster clone()
    {
        Debug.Log("I'm a ghost!");
        return new Ghost(hp, spd);
    }
}