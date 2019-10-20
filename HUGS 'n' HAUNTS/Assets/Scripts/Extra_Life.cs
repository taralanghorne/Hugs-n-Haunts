using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extra_Life : MonoBehaviour
{
    public int scoreAmount = 100;
    public AudioClip sound;
    public GameObject collectible;

    void OnTriggerEnter2D(Collider2D trig)
    {

        if (trig.gameObject.tag == "Player")
        {
            PlayerScoreSpookster.playerscore += scoreAmount;
            AudioSource.PlayClipAtPoint(sound, transform.position);
            SpooksterHealth.lives += 1;
            Destroy(collectible);
        }
    }
}
