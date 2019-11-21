using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{
    public GameObject destroyObj;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            destroyObj.SetActive(false);
            Destroy(destroyObj);
        }

    }
}
