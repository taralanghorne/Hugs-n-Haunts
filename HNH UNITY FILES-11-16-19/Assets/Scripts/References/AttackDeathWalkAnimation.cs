using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AttackDeathWalkAnimation : MonoBehaviour
{
    public GameObject zombAtt;
    GameObject plyr;

    public AudioClip zombDie; //prepare the slot for ZombieDeath audioclip

    bool zombieKilled = false;

    //walk
    public GameObject zombie;
    private Transform player;
    public int movespeed = 3;
    public float smoothTime = 10.0f;
    private Vector3 smoothVelocity = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {
        plyr = GameObject.FindGameObjectWithTag("Player");
        //Automatically finds GameObject with "Player" tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    //script from counter code

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Rock" && zombieKilled == false)
        {
            Debug.Log("Death Animation Played");
            GetComponent<Animation>().Play("Zombie_Death_01"); //play death animation
            Destroy(gameObject, 1.2f); //delay 1,2 seconds before destory the zombie
            AudioSource.PlayClipAtPoint(zombDie, transform.position);
            //ScoreCount.gscore += 1;
            zombieKilled = true;
        }
    }



    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(gameObject.transform.position, plyr.transform.position);
        //distance variable to calculate the 3D distance (Vector3) between the zombie and player.

        if (dist < 3.0f && zombieKilled == false)
        {
            //zombie.transform.LookAt(player);
            GetComponent<Animation>().Play("Zombie_Attack_01"); //Play "Attack" Animation
            zombAtt.SetActive(true); //Activate the Zombie Attack audio clip
        }

        if (dist > 3.0f && dist < 7.0f && zombieKilled == false)
        {
            //zombie.transform.LookAt(player);
            GetComponent<Animation>().Play("Zombie_Walk_01"); //Play "Walk" Animation
            zombAtt.SetActive(false); //Deactivate the Zombie Attack audio clip
            zombie.transform.position = Vector3.SmoothDamp(transform.position, player.position, ref smoothVelocity, smoothTime);
        }

        if (dist > 7.0f && zombieKilled == false)
        {
            GetComponent<Animation>().Play("Zombie_Idle_01"); //Play "Idle" Animation
            zombAtt.SetActive(false); //Deactivate the Zombie Attack audio clip
        }
    }
}
