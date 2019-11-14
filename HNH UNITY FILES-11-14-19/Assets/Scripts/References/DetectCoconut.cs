using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCoconut : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Coconut")
        {
            if (!col.gameObject.GetComponent<Rigidbody>())
            {
                col.gameObject.AddComponent<Rigidbody>();
            }
        }
    }
}
