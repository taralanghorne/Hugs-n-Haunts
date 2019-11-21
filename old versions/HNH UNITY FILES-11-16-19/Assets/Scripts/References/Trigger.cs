using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    bool lightOn = false;
    private void OnTriggerEnter(Collider myCollider)
    {
        if (myCollider.gameObject.name == "RigidBodyFPSController"&&lightOn==false)
        {
            Light myLight = GameObject.Find("Light").GetComponent<Light>();
            myLight.intensity = 2.0f;
            lightOn = true;
        }
    }
    private void OnTriggerExit(Collider myCollider)
    {
        if (myCollider.gameObject.name == "RigidBodyFPSController"&&lightOn==true)
        {
            Light myLight = GameObject.Find("Light").GetComponent<Light>();
            myLight.intensity = 0.2f;
            lightOn = false;        
        }
    }
}
