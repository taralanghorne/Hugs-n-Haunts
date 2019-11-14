using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScore : MonoBehaviour
{
    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name=="RigidBodyFPSController"){
            ScoreCount.gscore += 1; //add score
            Destroy(gameObject);
        }

    }
}
