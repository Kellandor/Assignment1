using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    Color col = Color.red;
    Color col2;
    Vector3 oldpos;
    Vector3 newpos = new Vector3(4f,1f,-5f);
    // Use this for initialization
    void Start () {
        col2 = this.GetComponent<Renderer>().material.color;
        oldpos = this.transform.position;
    }
	
    public void render()
    {
        this.gameObject.GetComponent<Renderer>().material.color = Color.Lerp(col2, col, Mathf.PingPong(Time.time,1));
    }

    public void transition()
    {
        this.gameObject.transform.position = Vector3.Lerp(oldpos,newpos,Mathf.PingPong(Time.time,1));
    }

    void getInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Ouch!");
        }
    }

	// Update is called once per frame
	void Update () {

    }
}
