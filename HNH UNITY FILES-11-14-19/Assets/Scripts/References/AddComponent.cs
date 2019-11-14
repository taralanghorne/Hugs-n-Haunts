using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddComponent : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube_RED")
        {
            if(!col.gameObject.GetComponent<Rigidbody>()){
                col.gameObject.AddComponent<Rigidbody>();
            }
        }
    }
}