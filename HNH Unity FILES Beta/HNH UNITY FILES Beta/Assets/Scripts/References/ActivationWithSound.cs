using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationWithSound : MonoBehaviour
{
    [SerializeField] private GameObject displayed;
    public AudioClip dialogue;

    void Start()
    {
        displayed.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            displayed.SetActive(true);
            AudioSource.PlayClipAtPoint(dialogue, transform.position);
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            displayed.SetActive(false);
        }
    }
}
