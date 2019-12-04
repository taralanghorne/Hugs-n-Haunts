using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(cube, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Fire1"))
        if(Input.GetKeyDown(KeyCode.C)){
            Instantiate(cube, transform.position, transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(sphere, transform.position, transform.rotation);
        }
    }
}
