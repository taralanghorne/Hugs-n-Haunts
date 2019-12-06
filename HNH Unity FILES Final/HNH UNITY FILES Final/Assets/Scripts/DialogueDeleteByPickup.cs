using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueDeleteByPickup : MonoBehaviour
{
    public GameObject dialogueTrigger;
    public GameObject dialogue;
    public GameObject speechBubble;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        speechBubble.SetActive(false);
        dialogue.SetActive(false);
        dialogueTrigger.SetActive(false);
    }
}
