using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorThru : MonoBehaviour
{
    public GameObject wall;
    public GameObject orbText;
    public GameObject orbSpeechBubble;
    //public Transform mainCamera;
    public AudioClip door;
    public GameObject passThrough;

    private void OnTriggerEnter2D(Collider2D other)
    {
        wall.SetActive(false);
        orbText.SetActive(false);
        orbSpeechBubble.SetActive(false);
        passThrough.SetActive(false);
        AudioSource.PlayClipAtPoint(door, transform.position);
    }
}
