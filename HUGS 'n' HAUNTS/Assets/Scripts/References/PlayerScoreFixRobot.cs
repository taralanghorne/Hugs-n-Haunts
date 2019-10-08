using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreFixRobot : MonoBehaviour
{
    // attach this script to the player

    //public GameObject fixbot; // tag as "Fixbot" -- for the non-decoy bots
    //public GameObject decoybot; // tag as "Decoy"

    //bool fixbotTrigger = false; // says you are in robot trigger volume -- non-decoy
    //bool fixedTheBot = false; // says whether you've fixed the robot (so can't multiple times)

    //bool decoybotTrigger = false; // says you are in decoy bot trigger volume

    /*public AudioClip robotbeep; // robot audio
    public AudioClip happybeep; // robot audio
    public Material matFixed; // mat for fixed robot (display the number?)*/

    public Text scoreText; // score text in UI--leave empty
    public Text botText; // text in UI shows how many bots you've fixed--leave empty

    public static int playerscore; // score
    public static int robotCount = 0; // score number -- kept static for convenience across multiple scripts
    public int botsToFix = 1; // set how many bots you want to fix per level -- kept as static for now

    public GameObject winLevelText; // text that says you won the level
    public static bool doorUnlocked = false;
    //public string levelToLoad; // says which level you want to go to next

    public float timer = 1000f; // time
    // Start is called before the first frame update
    public Text timeText; // displays countdown
    public GameObject endTime; // text if you lose--set not active at start
    public string loseLevel; // level to load when you lose because time ran out

    void Update()
    {
        botText.text = robotCount + " Out of " + botsToFix + " Robots to Fix"; // how many bots you've fixed
        if (robotCount >= botsToFix) // if have enough bots now door is unlocked
        {
            winLevelText.SetActive(true); // text tells player they can open the door if desired
            doorUnlocked = true; // can now open the door--should trigger updated DoorOpen script to work
            /* StartCoroutine(ChangeLevel()); // will start short countdown to level change if you uncomment--just activate the IEnumerator function below
            ChangeLevel(); // will change level */
        }

        scoreText.text = "Score: " + playerscore; // display player score

        timeText.text = "Time Left: " + (int)timer; // displays the time in integers

        if (timer > 0)
        {
            timer -= Time.deltaTime; // counts down time if not 0
        }
        else if (timer <= 0) // if time is 0
        {
            Debug.Log("GAME OVER"); // for testing
            endTime.SetActive(true); // display that you lost
            //wait and end level
            StartCoroutine(LoseLevel()); // start countdown to change to lose level
            //LoseLevel();
        }
    }

    IEnumerator LoseLevel() // if you lose the level because time ran out
    {
        yield return new WaitForSeconds(2); // waits for 2 seconds
        Application.LoadLevel(loseLevel); // loads lose screen
    }

    /*IEnumerator ChangeLevel()
    {
        yield return new WaitForSeconds(3);
        Application.LoadLevel(levelToLoad);
    }*/

    /*public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "RobotTrigger") // if you are in robot trigger volume -- non-decoy bot
        {
            fixbotTrigger = true;
        } else if (col.gameObject.tag == "DecoyTrigger")
        {
            decoybotTrigger = true;
        }

    }

    public void OnCollisionExit(Collision collision)
    {
        fixbotTrigger = false;
        decoybotTrigger = false;
    }

    public void FixBot(){
        if (fixbotTrigger == true && fixedTheBot == false && Input.GetKeyDown(KeyCode.F)){
            robotCount += 1;
            AudioSource.PlayClipAtPoint(happybeep, transform.position);
            //matFixed?
            fixedTheBot = true;
            //fixbot.GetComponent<Animator>().SetBool("Fixed", true);
        }
    }*/
}
