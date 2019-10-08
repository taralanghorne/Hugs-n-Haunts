using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_Score : MonoBehaviour {

    public float timeLeft = 1000;
    public int playerScore = 0;
    public GameObject timeLeftUI;
    public GameObject playerScoreUI;
    public GameObject loseUI;

    public AudioClip heart;
    public AudioClip sprinkles;

    public GameObject loseText;
    public static bool lose = false;
	
    void Start () {
        //Just for testing
        Data_Management.dataManagement.LoadData();
    }

	void Update () {
        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time: " + (int)timeLeft);
        playerScoreUI.gameObject.GetComponent<Text>().text = ("Score: " + playerScore);
        loseUI.gameObject.GetComponent<Text>().text = ("lose: " + lose);
        if (timeLeft < 0.1f) {
            loseText.SetActive(true);
            lose = true;
            timeLeft = 0;
            StartCoroutine(LoseLevel());
            //SceneManager.LoadScene ("GameLose");
        } 
    }

    void OnTriggerEnter (Collider trig) {
        if (trig.gameObject.name == "End_Level") {
            CountScore();
        }
        if (trig.gameObject.name == "Health")
        {
            playerScore += 10;
            AudioSource.PlayClipAtPoint(heart, transform.position);
                    
        }
        if (trig.gameObject.tag == "Coin")
        {
            playerScore += 20;
            AudioSource.PlayClipAtPoint(sprinkles, transform.position);

        }
    }

    void CountScore () {
        Debug.Log("Data says high score is currently" + Data_Management.dataManagement.highScore);
        playerScore = playerScore + (int)(timeLeft * 10);
        Data_Management.dataManagement.highScore = playerScore + (int)(timeLeft * 10);
        Data_Management.dataManagement.SaveData();
        Debug.Log(message: "Now that we have added the score to Data_Management, data says high score is currently" + Data_Management.dataManagement.highScore);
    }

    IEnumerator LoseLevel(){
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("GameLose");
        lose = false;
    }
}
