using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{


    public GameObject collectible;
    public GameObject smoke;
    //public GameObject cookiepoof;
    private int hitRange = 5;

    public AudioClip attack;
    public AudioClip poof;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Attack();
        }
    }

    void Attack()
    {
        AudioSource.PlayClipAtPoint(attack, transform.position);
        RaycastHit hit;
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 origin = transform.position;
        //animate
        //audio?

        if (Physics.Raycast(origin, forward, out hit, hitRange))
        {
            if(hit.transform.gameObject.tag == "Enemy"){
                AudioSource.PlayClipAtPoint(poof, transform.position);
                Instantiate(collectible, hit.transform.gameObject.transform.position, hit.transform.gameObject.transform.rotation);
                Instantiate(smoke, hit.transform.gameObject.transform.position, hit.transform.gameObject.transform.rotation);
                Destroy(hit.transform.gameObject);
                //make it length of animation or audio
            }
            /*if (hit.transform.gameObject.tag == "Cookie")
            {
                AudioSource.PlayClipAtPoint(poof, transform.position);
                Instantiate(collectible, hit.transform.gameObject.transform.position, hit.transform.gameObject.transform.rotation);
                Instantiate(cookiepoof, hit.transform.gameObject.transform.position, hit.transform.gameObject.transform.rotation);
                Destroy(hit.transform.gameObject);
                //make it length of animation or audio
            }*/
        }
    }
}