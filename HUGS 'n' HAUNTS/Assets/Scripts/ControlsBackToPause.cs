using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsBackToPause : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject controlsMenu;

    //On click
    public void ControlsToPause()
    {
        //game is already paused

        pauseMenu.SetActive(true); //bring up pause menu
        controlsMenu.SetActive(false); //bring up pause menu

    }
}
