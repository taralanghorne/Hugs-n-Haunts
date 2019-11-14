using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelSequence : MonoBehaviour
{
    public string levelToLoad;
    public GameObject fireworks;
    public Transform fireworksT;
    public GameObject text;
    public GameObject player;
    public Transform mainCamera;
    public AudioClip win;

    private void OnTriggerEnter(Collider other)
    {
        if (Player_Score.lose != true)
        {
            //player.transform.LookAt(mainCamera);
            mainCamera.transform.LookAt(fireworksT);
            Debug.Log("End Level");
            fireworks.SetActive(true);
            text.SetActive(true);
            AudioSource.PlayClipAtPoint(win, transform.position);
            StartCoroutine(EndLevel());
        }
    }

    IEnumerator EndLevel(){
        yield return new WaitForSeconds(5);
        Application.LoadLevel(levelToLoad);
    }
}

