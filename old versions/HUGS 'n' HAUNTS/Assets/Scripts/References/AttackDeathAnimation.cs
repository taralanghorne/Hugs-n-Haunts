using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackDeathAnimation : MonoBehaviour
{
    public GameObject zombAtt;
    GameObject plyr;

    public AudioClip zombDie; //prepare the slot for ZombieDeath audioclip

    bool zombieKilled = false;

    // Start is called before the first frame update
    void Start()
    {
        plyr = GameObject.FindGameObjectWithTag("Player");
        //Automatically finds GameObject with "Player" tag
    }
    //script from counter code

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Rock" && zombieKilled == false){
            Debug.Log("Death Animation Played");
            GetComponent<Animation>().Play("Zombie_Death_01"); //play death animation
            Destroy(gameObject, 1.2f); //delay 1,2 seconds before destory the zombie

            AudioSource.PlayClipAtPoint(zombDie, transform.position);

            ScoreCount.gscore += 1;

            zombieKilled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, plyr.transform.position);
        //distance variable to calculate the 3D distance (Vector3) between the zombie and player.

        if (dist <= 5.0f && zombieKilled == false) 
        {
            GetComponent<Animation>().Play("Zombie_Attack_01"); //Play "Attack" Animation
            zombAtt.SetActive(true); //Activate the Zombie Attack audio clip
        }

        if (dist > 5.0f && zombieKilled == false)
        {
            GetComponent<Animation>().Play("Zombie_Idle_01"); //Play "Idle" Animation
            zombAtt.SetActive(false); //Deactivate the Zombie Attack audio clip
        }
    }
}

