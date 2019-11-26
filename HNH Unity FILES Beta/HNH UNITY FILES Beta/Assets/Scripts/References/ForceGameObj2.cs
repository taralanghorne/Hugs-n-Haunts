using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceGameObj2 : MonoBehaviour
{
    public GameObject sphere;

    public void upForce()
    {
        sphere.GetComponent<Rigidbody>().AddForce(0, 1000.0f, 0);
    }

    public void downForce()
    {
        sphere.GetComponent<Rigidbody>().AddForce(0, -1000.0f, 0);
    }

    public void rightForce()
    {
        sphere.GetComponent<Rigidbody>().AddForce(1000.0f, 0, 0);
    }

    public void leftForce()
    {
        sphere.GetComponent<Rigidbody>().AddForce(-1000.0f, 0, 0);
    }
}
