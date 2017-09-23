using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breed {
    private int hp;
    private int jump;
    Breed parent;

    public Enemy newMonster()
    {
        return new Enemy(this);
    }

    public Breed(Breed b, int health, int a)
    {
        parent = b;
        hp = health;
        jump = a;
    }

    public int getHealth()
    {
        if(hp != 0 || parent == null)
        {
            return hp;
        }
        return parent.getHealth();
    }

    public int getJump()
    {
        if(jump != 0 || parent == null)
        {
            return jump;
        }

        return parent.getJump();
    }
}
