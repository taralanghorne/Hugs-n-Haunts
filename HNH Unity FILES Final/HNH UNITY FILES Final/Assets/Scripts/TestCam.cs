using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCam : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject tourist;
    //public float speed = 0.02f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log("moving");
            mainCamera.gameObject.transform.position = new Vector2(tourist.transform.position.x, tourist.transform.position.y);
        }
    }
}
