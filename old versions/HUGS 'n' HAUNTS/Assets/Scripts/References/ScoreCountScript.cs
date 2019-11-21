using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCountScript : MonoBehaviour
{
    public static int gscore = 0;
    //static variables are shared across all instances of a class

    public Text scoreText;
    public GameObject winText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + gscore;
        if (gscore >= 5){
            winText.SetActive(true);
        }
    }

}
