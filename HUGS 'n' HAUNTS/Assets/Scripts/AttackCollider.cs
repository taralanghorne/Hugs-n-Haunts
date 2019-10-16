using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollider : MonoBehaviour
{
    public AudioClip enemydeath; //for health pickups
    public GameObject collectible;
    GameObject pumpkin;
    public Transform clonePosition;

    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.transform.gameObject.tag == "Enemy")
        {
            AudioSource.PlayClipAtPoint(enemydeath, transform.position);
            //clonePosition = trig.transform.position;
            //Instantiate(collectible, trig.transform.position, trig.transform.gameObject.transform.rotation);
            pumpkin = (GameObject) Instantiate(collectible, trig.transform.position, trig.transform.rotation);
            pumpkin.transform.localScale = new Vector3(0.2336f, 0.2336f, 0.73f);
            //Instantiate(smoke, hit.transform.gameObject.transform.position, hit.transform.gameObject.transform.rotation);
            Destroy(trig.transform.gameObject);
            //make it length of animation or audio
        }
    }
}
