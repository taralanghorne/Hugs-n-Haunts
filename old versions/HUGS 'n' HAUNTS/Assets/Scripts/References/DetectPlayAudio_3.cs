using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectPlayAudio_3 : MonoBehaviour
{
    public AudioClip explosionClip;
    AudioSource audioSource;

    public Renderer rend;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "RigidBodyFPSController")
        {
            Debug.Log("HIT the CUBE");
            rend.enabled = false;
            audioSource = GetComponent<AudioSource>();
            audioSource.PlayOneShot(explosionClip);
            Destroy(gameObject, explosionClip.length);
            Debug.Log("Destroyed the CUBE");
        }
    }
}
