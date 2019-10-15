﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpooksterHealth : MonoBehaviour
{
    // InstaDeath objects should be tagged "Death" and set as a trigger
    // Enemies (and other 1-damage obstacles) should be tagged "Enemy" and should NOT be set as a trigger

    //private GameObject respawn;
    public static Vector2 lastCheck;

    //private int playerScore;


    /*[Tooltip("The score value of a coin or pickup.")]
    public int coinValue = 5;
    [Tooltip("The amount of points a player loses on death.")]
    public int deathPenalty = 20;*/

    //public Text scoreText;
    // Feel free to add more! You'll need to edit the script in a few spots, though.
    public GameObject health5;
    public GameObject health4;
    public GameObject health3;
    public GameObject health2;
    public GameObject health1;

    //public AudioClip hurt;





    // Use this for initialization
    void Start()
    {
        //respawn = GameObject.FindGameObjectWithTag("respawn");
        //playerScore = 0;
        //  scoreText.text = playerScore.ToString("D4");

    }



    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Death"))
        {
            //AudioSource.PlayClipAtPoint(hurt, transform.position);
            Debug.Log("Hey man you're dead");
            Respawn();
        }
        /*else if (collision.CompareTag("Coin"))
        {
            AddPoints(coinValue);
            Destroy(collision.gameObject);
        }*/
        else if (collision.CompareTag("Finish"))
        {
            Time.timeScale = 0;
        }
        else if (collision.CompareTag("Health"))
        {
            AddHealth();
            Destroy(collision.gameObject);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            //AudioSource.PlayClipAtPoint(hurt, transform.position);
            TakeDamage();
        }
    }

    private void TakeDamage()
    {
        // For more health, copy the if block for health3, change health3 to whatever yours is,
        // then change the if statement for health3 to else if


        if (health5.activeInHierarchy)
        {
            health5.SetActive(false);
        }
        else if (health4.activeInHierarchy)
        {
            health4.SetActive(false);
        }
        else if (health3.activeInHierarchy)
        {
            health3.SetActive(false);
        }
        else if (health2.activeInHierarchy)
        {
            health2.SetActive(false);
        }
        else
        {
            health1.SetActive(false);
            Respawn();
        }


        //assuming that health 3, health 2, health 1 are like their hearts or something
    }

    private void AddHealth()
    {
        if (!health2.activeInHierarchy)
        {
            health2.SetActive(true);
        }
        else if (!health3.activeInHierarchy)
        {
            health3.SetActive(true);
        }
        else if (!health4.activeInHierarchy)
        {
            health4.SetActive(true);
        }
        else if (!health5.activeInHierarchy)
        {
            health5.SetActive(true);
        }
        // For more health, just copy the else if block for health3 and change the name.
    }

    public void Respawn()
    {
        // For more health, just add another similar line here.
        health5.SetActive(true);
        health4.SetActive(true);
        health3.SetActive(true);
        health2.SetActive(true);
        health1.SetActive(true);
        gameObject.GetComponent<Rigidbody>().velocity = Vector2.zero;
        //gameObject.transform.position = respawn.transform.position;
        gameObject.transform.position = lastCheck;
        //AddPoints(deathPenalty);
    }

    /*public int GetScore()
    {
        return playerScore;
    }*/

    /*public void AddPoints(int amount)
    {
        playerScore += amount;
        scoreText.text = playerScore.ToString("D4");
    }*/
}