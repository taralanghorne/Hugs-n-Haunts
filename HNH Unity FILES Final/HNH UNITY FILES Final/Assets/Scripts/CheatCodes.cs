using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatCodes : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpooksterHealth.lives = 5;
            SpooksterHealth.lose = false;
            PlayerScoreSpookster.playerscore = 0; // reset Score
            Extra_Life.extraLifeObtained = false;
            PauseScreenPressP.isPaused = false;
            Time.timeScale = 1;
            SceneManager.LoadScene(2); // Go to Level 1
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpooksterHealth.lose = false;
            Extra_Life.extraLifeObtained = false;
            PauseScreenPressP.isPaused = false;
            Time.timeScale = 1;
            SceneManager.LoadScene(3); // Go to Level 2
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene(6); // Go to Win Screen
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene(4); // Go to Lose Screen
        }
    }
}
