using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObject_deltatime : MonoBehaviour {
    
	// Update is called once per frame
	void Update () {
        transform.Translate(5, 0, 0);
	}
}
