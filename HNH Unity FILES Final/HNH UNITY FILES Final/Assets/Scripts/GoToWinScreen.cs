using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToWinScreen : MonoBehaviour
{
    public void Win()
    {
        SceneManager.LoadScene(6);
    }
}
