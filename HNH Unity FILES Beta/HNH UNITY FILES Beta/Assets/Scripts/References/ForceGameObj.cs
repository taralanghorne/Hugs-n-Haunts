using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceGameObj : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(0, 0, 1000.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
