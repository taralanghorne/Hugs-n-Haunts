using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    //pause menu variable
    public GameObject pauseMenu;
    public GameObject pauseButton;

    //On click
    public void PauseMenuOpen()
    {
        //pause the game code here:

        //open pause menu
        pauseMenu.SetActive(true); //bring up pause menu
        pauseButton.SetActive(false); //turn off pause button so can't click again while in pause window
    }
}
