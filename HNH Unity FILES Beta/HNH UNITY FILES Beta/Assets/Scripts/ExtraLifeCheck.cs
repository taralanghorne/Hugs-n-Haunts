using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraLifeCheck : MonoBehaviour
{
    public GameObject dialogue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Extra_Life.extraLifeObtained)
        {
            StartCoroutine(DialogueOff());
        }
    }

    IEnumerator DialogueOff()
    {
        yield return new WaitForSeconds(3);
        Debug.Log("dialogue off");
        dialogue.SetActive(false);
    }
}
