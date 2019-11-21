using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMaterial : MonoBehaviour
{
    public GameObject cube;
    public Material matRed;
    public Material matBlue;
    public Material matGreen;
    public Material matTexture;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            cube.GetComponent<Renderer>().material = matRed;

        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            cube.GetComponent<Renderer>().material = matBlue;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            cube.GetComponent<Renderer>().material = matGreen;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            cube.GetComponent<Renderer>().material = matTexture;
        }
    }
}
