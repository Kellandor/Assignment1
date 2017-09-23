using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Monster monster = new Ghost(10, 5);
        Spawner spawn = new Spawner(monster);
        spawn.spawn();

        monster = new Dragon(50, 10);
        spawn = new Spawner(monster);
        spawn.spawn();
    }
	
	// Update is called once per frame
	void Update () {

    }
}
