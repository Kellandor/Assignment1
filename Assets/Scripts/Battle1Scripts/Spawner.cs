using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner
{
    Monster prototype;
    public Spawner(Monster m)
    {
        prototype = m;
    }

    public Monster spawn()
    {
        Debug.Log("Spawning " + prototype);
        return prototype.clone();
    }
}
