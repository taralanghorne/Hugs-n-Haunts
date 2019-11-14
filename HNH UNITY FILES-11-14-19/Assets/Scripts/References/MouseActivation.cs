using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseActivation : MonoBehaviour {

    public GameObject displayed;
    public AudioClip Creak;

    void Start()
    {
        displayed.SetActive(false);
    }

    // Use this for initialization
    public void OnMouseDown()
    {
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(Creak, 0.9f * Camera.main.transform.position + 0.1f * transform.position, 50f);
        displayed.SetActive(true);
    }
}


