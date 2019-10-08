using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsPopUp : MonoBehaviour
{
    //pause menu variable
    public GameObject pauseMenu;
    public GameObject controlsMenu;

    //On click
    public void ControlsMenuOpen()
    {
        //game is already paused

        pauseMenu.SetActive(false); //bring up pause menu
        controlsMenu.SetActive(true); //bring up pause menu
    }
}
