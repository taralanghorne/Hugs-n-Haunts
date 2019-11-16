using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickNextDialogueTwoSounds : MonoBehaviour
{
    //public GameObject buttonClicking;
    public GameObject pastText; // group of text/buttons that you have read - will disappear
    public GameObject newText; // group of text/buttons that is next - will appear
    public GameObject sound; // sound effect to play when transitioning
    public GameObject sound2; // sound effect to play when transitioning

    public void ClickChoiceSound()
    {
        newText.SetActive(true); // makes new text/buttons appear
        pastText.SetActive(false); // makes old text/buttons disappear
        sound.SetActive(true); // makes new text/buttons appear
        sound2.SetActive(true); // makes new text/buttons appear
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
