using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    Breed b;
    Breed orc;
    Vector3 oldpos, newpos;
    // Use this for initialization
    void Start()
    {
        b = new Breed(null, 50, 10);
        orc = new Breed(b, 0, 0);

        oldpos = this.transform.position;
        newpos = new Vector3(oldpos.x, (oldpos.y + orc.getJump()), oldpos.z);
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = Vector3.Lerp(oldpos, newpos, Mathf.PingPong(Time.time, 1));
    }
}
