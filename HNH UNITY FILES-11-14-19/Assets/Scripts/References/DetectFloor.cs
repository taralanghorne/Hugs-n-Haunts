using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFloor : MonoBehaviour {

	void OnCollisionEnter(Collision col)
	{
        if(col.gameObject.name=="Floor"){
            Debug.Log("Hit The FLOOR");
        }
	}
}
