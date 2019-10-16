using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpooksterAttack : MonoBehaviour
{
    private bool Attack = false;
    public GameObject AttackRight;
    public GameObject AttackLeft;
    public AudioClip punch; //for health pickups

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Attacking");
            AudioSource.PlayClipAtPoint(punch, transform.position);
            //gameObject.GetComponent<Animator>().SetBool("Punch1", true);
            Attack = true;
            if (SpooksterMove.isRight)
            {
                AttackRight.SetActive(true);
                Invoke("Attack_Right_Cancel", 0.3f);
            } else if (SpooksterMove.isLeft)
            {
                AttackLeft.SetActive(true);
                Invoke("Attack_Left_Cancel", 0.3f);
            }
            
        }
    }

    void Attack_Right_Cancel()
    {
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        Attack = false;
        AttackRight.SetActive(false);
    }

    void Attack_Left_Cancel()
    {
        //gameObject.GetComponent<Animator>().SetBool("Punch1", false);
        Attack = false;
        AttackLeft.SetActive(false);
    }
}
