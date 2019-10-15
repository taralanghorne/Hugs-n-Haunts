using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScoreSpookster : MonoBehaviour
{
    //public float timeLeft = 1000;
    public static int playerscore; // score--needs to be static to carry over between levels
    //public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    //public GameObject loseUI;

    public AudioClip heart; //for health pickups
    public AudioClip pumpkins;//for collectible pumpkins
    public AudioClip orb;//for collectible pumpkins
    public AudioClip life;//for collectible pumpkins

    //public GameObject loseText;
    //public static bool lose = false;

    void Start()
    {
        //Just for testing
        Data_Management.dataManagement.LoadData();
    }


    void Update()
    {
        //timeLeft -= Time.deltaTime;
        ////timeLeftUI.gameObject.GetComponent<Text>().text = ("Time " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score " + playerscore);
        //loseUI.gameObject.GetComponent<Text>().text = ("lose " + lose);
        /*if (timeLeft < 0.1f)
        {
            loseText.SetActive(true);
            lose = true;
            timeLeft = 0;
            StartCoroutine(LoseLevel());
            //SceneManager.LoadScene ("GameLose");
        }*/
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        /*if (trig.gameObject.name == "End_Level")
        {
            CountScore();
        }*/
        if (trig.gameObject.tag == "Health")//heart pumpkins
        {
            playerscore += 30;
            AudioSource.PlayClipAtPoint(heart, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.tag == "Collectible") //pumpkins
        {
            playerscore += 20;
            AudioSource.PlayClipAtPoint(pumpkins, transform.position);
            Destroy(trig.gameObject);
        }

        if (trig.gameObject.tag == "SpiritOrb") //orbs
        {
            playerscore += 50;
            AudioSource.PlayClipAtPoint(orb, transform.position);
            Destroy(trig.gameObject);
        }
        if (trig.gameObject.tag == "Life") //extra lives
        {
            playerscore += 100;
            AudioSource.PlayClipAtPoint(life, transform.position);
            Destroy(trig.gameObject);
        }
    }

   /* void CountScore()
    {
        Debug.Log("Data says high score is currently" + Data_Management.dataManagement.highScore);
        playerscore = playerscore + (int)(timeLeft * 10);
        Data_Management.dataManagement.highScore = playerscore + (int)(timeLeft * 10);
        Data_Management.dataManagement.SaveData();
        Debug.Log(message: "Now that we have added the score to Data_Management, data says high score is currently" + Data_Management.dataManagement.highScore);
    }

    IEnumerator LoseLevel()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameLose");
        lose = false;
    }*/
}
