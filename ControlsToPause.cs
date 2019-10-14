using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsToPause : MonoBehaviour
{
    ///pause menu variable
    public GameObject pauseMenu;
    public GameObject controlsMenu;


    //On click
    public void ControlsOpenPause()
    {
        //pause the game code here:

        //open pause menu
        Debug.Log("switching");
        controlsMenu.SetActive(false); //bring up pause menu
        pauseMenu.SetActive(true); //turn off pause button so can't click again while in pause window
        Debug.Log("switching");
    }
}
