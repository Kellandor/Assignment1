using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public GameObject target1;
    public GameObject target2;
	// Use this for initialization
	void Start () {
        Debug.Log("Spacebar for jump (input)");
	}
	
	// Update is called once per frame
	void Update () {

        target1.GetComponent<Jump>().jump();
        target2.GetComponent<Move>().render();
        target2.GetComponent<Move>().transition();
    }
}
