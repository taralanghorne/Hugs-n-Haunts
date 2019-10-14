using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseToControls : MonoBehaviour
{
    ///pause menu variable
    public GameObject pauseMenu;
    public GameObject controlsButton;
    public GameObject controlsMenu;


    //On click
    public void ControlsMenuOpen()
    {
        //pause the game code here:

        //open pause menu
        controlsMenu.SetActive(true); //bring up pause menu
        pauseMenu.SetActive(false); //turn off pause button so can't click again while in pause window
    }
}
