using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WereAttack : MonoBehaviour
{
    public GameObject swipeTrigR;
    public GameObject swipeTrigL;
    public bool IsAttacking;
    public AudioClip growl; //for health pickups
    public GameObject werewolf;

    // Start is called before the first frame update
    void Start()
    {
        swipeTrigR.SetActive(false);
        swipeTrigL.SetActive(false);
        IsAttacking = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.transform.gameObject.tag == "Player")
        {
            IsAttacking = true;
            if (IsAttacking)
            {
                werewolf.GetComponent<Animator>().SetBool("IsAttacking", true);
                //werewolf.GetComponent<Patrol>().speed = 0;
                werewolf.GetComponent<AudioSource>().Play();
                //AudioSource.PlayClipAtPoint(growl, transform.position);
                if (werewolf.GetComponent<Patrol>().isRight)
                {
                    swipeTrigL.SetActive(true);
                    Invoke("Attack_Left_Cancel", 1.0f);
                }
                else if (werewolf.GetComponent<Patrol>().isRight == false)
                {
                    swipeTrigR.SetActive(true);
                    Invoke("Attack_Right_Cancel", 1.0f);
                }
            }
        }
    }

    /*private void OnTriggerExit2D(Collider2D trig)
    {
        if (trig.transform.gameObject.tag == "Player")
        {
            IsAttacking = false;
        }
    }*/

    void Attack_Right_Cancel()
    {
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        swipeTrigR.SetActive(false);
        IsAttacking = false;
        werewolf.GetComponent<Animator>().SetBool("IsAttacking", false);
        werewolf.GetComponent<AudioSource>().Stop();
    }

    void Attack_Left_Cancel()
    {
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        swipeTrigL.SetActive(false);
        IsAttacking = false;
        werewolf.GetComponent<Animator>().SetBool("IsAttacking", false);
        werewolf.GetComponent<AudioSource>().Stop();
    }
}
