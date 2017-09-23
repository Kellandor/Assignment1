using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : MonoBehaviour {
    Breed b;
    Breed troll;
    Vector3 oldpos, newpos;
	// Use this for initialization
	void Start () {
        b = new Breed(null, 50, 10);
        troll = new Breed(b, 0, 5);

        oldpos = this.transform.position;
        newpos = new Vector3(oldpos.x, (oldpos.y + troll.getJump()), oldpos.z );
    }
	
	// Update is called once per frame
	void Update () {
        this.gameObject.transform.position = Vector3.Lerp(oldpos, newpos, Mathf.PingPong(Time.time, 1));
    }
}
