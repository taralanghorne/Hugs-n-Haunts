using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointFlag : MonoBehaviour
{
    // Attach this to your checkpoints. Checkpoints should have a collider set to trigger.
    // If you want to make a sprite animate on activating the checkpoint, let me know! It shouldn't be too hard to program.
    //public GameObject respawn;
    private bool activated = false;
    public GameObject flag;
    public Material activeMat;
    public AudioClip activate;

    void Start()
    {
        //respawn = GameObject.FindGameObjectWithTag("Respawn");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (!activated)
        {
            if (collision.CompareTag("Player"))
            {
                AudioSource.PlayClipAtPoint(activate, transform.position);
                flag.GetComponent<Renderer>().material = activeMat;
                //animate
                Player_Health_Segmented.lastCheck = transform.position;
                activated = true;
            }
        }
    }
}
