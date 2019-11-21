using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpooksterAttack : MonoBehaviour
{
    private bool Attack = false;
    public GameObject AttackRight;
    public GameObject AttackLeft;
    public AudioClip punch; //for health pickups
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && !Attack)
        {
            Debug.Log("Attacking");
            Attack = true;
            //gameObject.GetComponent<Animator>().SetBool("Punch1", true);
            //Attack = true;
            //            player.GetComponent<Animator>().SetBool("IsAttacking", true);
            AttackCommand();
        }
    }

    void AttackCommand()
    {
        player.GetComponent<Animator>().SetBool("IsAttacking", true);
        if (SpooksterMove.isRight)
        {
            Debug.Log("AttackingR");
            AttackRight.SetActive(true);
            Debug.Log("Active");
            AudioSource.PlayClipAtPoint(punch, transform.position);
            Invoke("Attack_Right_Cancel", 0.2f);
        }
        else if (SpooksterMove.isLeft)
        {
            Debug.Log("AttackingL");
            AttackLeft.SetActive(true);
            Debug.Log("Active");
            AudioSource.PlayClipAtPoint(punch, transform.position);
            Invoke("Attack_Left_Cancel", 0.2f);
        }
    }
    void Attack_Right_Cancel()
    {
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        //player.GetComponent<Animator>().SetBool("IsAttacking", false);
        Attack = false;
        AttackRight.SetActive(false);
        player.GetComponent<Animator>().SetBool("IsAttacking", false);

    }

    void Attack_Left_Cancel()
    {
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        //player.GetComponent<Animator>().SetBool("IsAttacking", false);
        Attack = false;
        AttackLeft.SetActive(false);
        player.GetComponent<Animator>().SetBool("IsAttacking", false);

    }
}
