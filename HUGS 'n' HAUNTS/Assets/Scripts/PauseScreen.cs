using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : MonoBehaviour
{
    //pause menu variable
    public GameObject pauseMenu;

    //On click
    public void PauseMenuOpen()
    {
        //pause the game code here:

        //open pause menu
        pauseMenu.SetActive(true);
    }
}
