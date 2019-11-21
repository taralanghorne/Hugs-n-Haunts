using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name=="Wall"){
            Debug.Log("Hit the WALL");
        }
    }
}
