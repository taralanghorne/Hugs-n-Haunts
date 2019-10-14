using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject ball; //open slot for ball prefab
    float ballSpeed = 30f; //ball Speed

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Camera cam = Camera.main;
            GameObject theBall = (GameObject)Instantiate(ball, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            //throw the ball to the forward direction
            theBall.GetComponent<Rigidbody>().AddForce(cam.transform.forward * ballSpeed, ForceMode.Impulse);
            //adding force to our ball
        }
    }
}
