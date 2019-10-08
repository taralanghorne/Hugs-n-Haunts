using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //add this line

public class ScoreCount : MonoBehaviour {
// create ScriptManager and attach this script

	public static int gscore = 0;
    public string levelToLoad;

	public Text scoreText;
	public GameObject youWin;

	void Update(){
        scoreText.text = gscore + " Out of 13 Zombies";
		if (gscore >= 13) 
        {
            youWin.SetActive (true);
            StartCoroutine(ChangeLevel());
            ChangeLevel();
		}
	}
    IEnumerator ChangeLevel(){
        yield return new WaitForSeconds(2);
        Application.LoadLevel(levelToLoad);
    }
}
