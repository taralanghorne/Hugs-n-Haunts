﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistObj_2 : MonoBehaviour
{
    GameObject plyr;

    void Start()
    {
        plyr = GameObject.FindGameObjectWithTag("Player");
        //Automatically find GameObject with "Player" tag

    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(plyr.transform.position, gameObject.transform.position);

        Light myLight = GameObject.Find("Light").GetComponent<Light>();

        Debug.Log(dist);

        if (dist <= 5.0f){
            myLight.intensity = 12.0f;
        }
        else{
            myLight.intensity = 0.2f;
        }
    }
}