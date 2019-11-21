using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript1 : MonoBehaviour {
    public GameObject cube;
    public GameObject sphere;
    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetKeyDown(KeyCode.C))
            
        {
            Instantiate(cube, transform.position, transform.rotation);
        }else if (Input.GetKeyDown(KeyCode.S))

        {
            Instantiate(sphere, transform.position, transform.rotation);
        }
    }
}
