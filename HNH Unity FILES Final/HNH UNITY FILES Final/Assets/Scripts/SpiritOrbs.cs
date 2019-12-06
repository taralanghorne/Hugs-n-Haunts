using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiritOrbs : MonoBehaviour
{
    public GameObject orb3;
    public GameObject orb2;
    public GameObject orb1;

    public GameObject gotOrbsText;
    public GameObject gotOrbsSpeechBubble;
    public AudioClip dialogue;
    public GameObject wall;
    public GameObject door;
    public GameObject doorText;
    public GameObject doorSpeechBubble;
    public GameObject doorTextTrigger;
    public GameObject passThrough;

    // Use this for initialization
    void Start()
    {

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.CompareTag("SpiritOrb"))
        {
            AddOrb();
            Destroy(collision.gameObject);
        }*/


    }

    public void AddOrb()
    {
        if (!orb1.activeInHierarchy)
        {
            orb1.SetActive(true);
        }
        else if (!orb2.activeInHierarchy)
        {
            orb2.SetActive(true);
        }
        else if (!orb3.activeInHierarchy)
        {
            orb3.SetActive(true);
            GotOrbs();
        }
        // For more orbs, just copy the else if block for orb3 and change the name.
    }

    public void GotOrbs()
    {
        doorText.SetActive(false);
        doorSpeechBubble.SetActive(false);
        //doorTextTrigger.SetActive(false);
        Destroy(doorTextTrigger);
        gotOrbsText.SetActive(true);
        gotOrbsSpeechBubble.SetActive(true);
        AudioSource.PlayClipAtPoint(dialogue, transform.position);
        passThrough.SetActive(true);
        wall.GetComponent<BoxCollider2D>().enabled = false;
        door.GetComponent<BoxCollider2D>().enabled = true;

    }

}
