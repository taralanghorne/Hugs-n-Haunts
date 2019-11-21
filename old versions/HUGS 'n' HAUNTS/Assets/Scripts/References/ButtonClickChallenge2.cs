using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickChallenge2 : MonoBehaviour
{
    public GameObject sphere;
    public GameObject buttonUP;
    public GameObject buttonDOWN;
    public GameObject buttonLEFT;
    public GameObject buttonRIGHT;

    public void HitButtonSphere()
    {
        sphere.SetActive(true);
        buttonUP.SetActive(true);
        buttonDOWN.SetActive(true);
        buttonLEFT.SetActive(true);
        buttonRIGHT.SetActive(true);
    }

    public void goUP()
    {
        sphere.GetComponent<Rigidbody>().AddForce(0,100.0f, 0);
    }

    public void goDOWN()
    {
        sphere.GetComponent<Rigidbody>().AddForce(0,-100.0f,0);
    }

    public void goLEFT()
    {
        sphere.GetComponent<Rigidbody>().AddForce(-100.0f,0,0);
    }
    public void goRIGHT()
    {
        sphere.GetComponent<Rigidbody>().AddForce(-100.0f,0,0);
    }
}
