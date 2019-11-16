using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    public float timer = 5.0f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
            {
                timer -= Time.deltaTime;
            }

        if (timer <= 0)
            {
                Debug.Log("GAME OVER");
            }
     }
}

    
	

