using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public GameObject dialogue;
    public GameObject speechBubble;
    public GameObject dialogueTrigger;
    public AudioClip talk;
    public bool deactivateTrigger = true;

    // Start is called before the first frame update
    void Start()
    {
        dialogue.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            speechBubble.SetActive(true);
            dialogue.SetActive(true);
            AudioSource.PlayClipAtPoint(talk, transform.position);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && deactivateTrigger)
        {
            speechBubble.SetActive(false);
            dialogue.SetActive(false);
            dialogueTrigger.SetActive(false);
            Debug.Log("destroying dialogue");
        }
        else if (collision.CompareTag("Player") && !deactivateTrigger)
        {
            speechBubble.SetActive(false);
            dialogue.SetActive(false);
        }
    }
}