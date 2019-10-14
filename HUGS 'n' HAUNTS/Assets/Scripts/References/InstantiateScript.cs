using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateScript : MonoBehaviour {
    
    public GameObject cube;

    void Start()
    {
            Instantiate(cube, transform.position, transform.rotation);
    }
}
