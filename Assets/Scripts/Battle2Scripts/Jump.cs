using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody>();
	}
	
    public void jump()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, 500, 0);
        }
    }

	// Update is called once per frame
	void Update () {

	}
}
