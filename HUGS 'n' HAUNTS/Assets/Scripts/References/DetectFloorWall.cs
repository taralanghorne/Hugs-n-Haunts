using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFloorWall : MonoBehaviour
{
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Floor")
        {
            Debug.Log("Hit the FLOOR");
        }
        else if (col.gameObject.tag == "Wall"){
            Debug.Log("Hit the WALL");
        }

    }
}
