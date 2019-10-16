using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorThru : MonoBehaviour
{
    public GameObject wall;
    public GameObject orbText;
    //public GameObject tourist;
    //public Transform mainCamera;
    public AudioClip door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        wall.SetActive(false);
        orbText.SetActive(false);
        AudioSource.PlayClipAtPoint(door, transform.position);
    }
}
