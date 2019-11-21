using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel1 : MonoBehaviour
{
    public void Lev1()
    {
        SpooksterHealth.lives = 5;
        SpooksterHealth.lose = false;
        PlayerScoreSpookster.playerscore = 0; // reset Score
        SceneManager.LoadScene(2);
    }
}
