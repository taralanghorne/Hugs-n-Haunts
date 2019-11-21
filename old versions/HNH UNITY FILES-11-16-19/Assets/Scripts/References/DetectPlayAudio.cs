using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayAudio : MonoBehaviour
{
    public AudioClip dingClip;
    AudioSource audioSource;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            Debug.Log("Hit the CUBE");
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(dingClip);
        }
    }
}
