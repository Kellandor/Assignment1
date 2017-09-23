using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy{
    private int health;
    private Breed b;

    public Enemy(Breed breed)
    {
        health = breed.getHealth();
        b = breed;
    }

    public int jump()
    {
        return b.getJump();
    }
}
