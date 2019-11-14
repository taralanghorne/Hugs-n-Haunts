using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {
    public Transform pointA;
    public Transform pointB;
    public GameObject triggerL;
    public GameObject triggerR;
    public bool isRight = true;
    public float speed = 0.3f;
    private Vector3 pointAPosition;
    private Vector3 pointBPosition;
    // Use this for initialization
    void Start()
    {
        pointAPosition = new Vector3(pointA.position.x, 0, 0);
        pointBPosition = new Vector3(pointB.position.x, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 thisPosition = new Vector3(transform.position.x, 0, 0);
        if (isRight)
        {
            transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed);
            triggerL.SetActive(true);
            if (thisPosition.Equals(pointBPosition))
            {
                //Debug.Log ("Position b");
                isRight = false;
                triggerL.SetActive(false);
                GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, pointA.position, speed);
            triggerR.SetActive(true);
            if (thisPosition.Equals(pointAPosition))
            {
                //Debug.Log ("Position a");
                isRight = true;
                triggerR.SetActive(false);
                GetComponent<SpriteRenderer>().flipX = false;
            }
        }
    }
}