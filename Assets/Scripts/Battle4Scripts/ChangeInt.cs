using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeInt : MonoBehaviour {
    public Light l;
    static int max = 16;
    LightScript ls;
    static PlayMessage[] pending = new PlayMessage[max];
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        for (int i= 0; i < max; i++)
        {
            //pending[i].intensity = (float)i;
            l.intensity += i;
        }
	}
}
