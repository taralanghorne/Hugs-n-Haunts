using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetection_2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider myCollider)
    {
        if(myCollider.gameObject.name=="RigidBodyFPSController")
        {
            Light myLight = GameObject.Find("Light").GetComponent<Light>();
            //myLight.enabled = true;
            myLight.intensity = 5.0f;
            Debug.Log("HIT THE PLAYER");
        }
    }
}
