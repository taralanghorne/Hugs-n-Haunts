using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    void OnTriggerEnter(Collider myCollider)
    {
        if(myCollider.gameObject.name == "Collider")
        {
            Debug.Log("HIT THE COLLIDER");
        }
    }
}
