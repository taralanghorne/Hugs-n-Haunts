using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void OpenMainMenu()
    {
        SpooksterHealth.lives = 5;
        SpooksterHealth.lose = false;
        PlayerScoreSpookster.playerscore = 0; // reset Score
        Extra_Life.extraLifeObtained = false;
        PauseScreenPressP.isPaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
