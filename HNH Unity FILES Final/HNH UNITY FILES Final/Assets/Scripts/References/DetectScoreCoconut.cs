using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoreCoconut : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Coconut")
        {
            ScoreCoconut.gscore += 1; //add score
            Debug.Log("Hit");
           // Destroy(gameObject);
        }

    }
}
