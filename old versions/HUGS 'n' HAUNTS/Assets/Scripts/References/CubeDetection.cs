using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDetection : MonoBehaviour
{
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag=="cube"){
            if(!col.gameObject.GetComponent<Rigidbody>()){
                col.gameObject.AddComponent<Rigidbody>();
            }
        }
    }
}
