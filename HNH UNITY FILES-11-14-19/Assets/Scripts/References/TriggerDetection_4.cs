using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection_4 : MonoBehaviour {
    public string levelToLoad_A;
    public string levelToLoad_B;
    public string levelToLoad_C;
	// Use this for initialization
	void OnTriggerEnter (Collider myCollider) {
        if (myCollider.gameObject.name == "Trigger_A")
        {
            Debug.Log("Go To LEVEL RED");
            Application.LoadLevel(levelToLoad_A);
        }else if (myCollider.gameObject.name == "Trigger_B")
        {
            Debug.Log("Go To LEVEL BLUE");
            Application.LoadLevel(levelToLoad_B);
        }else if (myCollider.gameObject.name == "Trigger_C")
        {
            Debug.Log("Go To LEVEL GREEN");
            Application.LoadLevel(levelToLoad_C);
        }
	}
}
