using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel2 : MonoBehaviour
{
    public GameObject tourist;
    public Transform mainCamera;
    public AudioClip scream;
    public Transform runPosition;
    private Vector3 door;
    public float speed = 0.3f;
    private float step;
    public GameObject touristDialogue;
    private bool animating = false;

    public GameObject pressT;
    public AudioClip huh;
    bool trigger = false;
    bool soundOff = false;

    void Start()
    {
        door = new Vector3(runPosition.position.x, runPosition.position.y, 0);
        //tourist.GetComponent<SpriteRenderer>().flipX = true;
    }

    private void Update()
    {
        if (animating)
        {
            //animation here
            //step = speed * Time.deltaTime;
            //tourist.transform.position = Vector3.MoveTowards(tourist.transform.position, door, speed);
        }

        if (trigger && Input.GetKeyDown(KeyCode.T))
        {
            Destroy(pressT);
            soundOff = true;
            //mainCamera.gameObject.transform.position = new Vector2(tourist.transform.position.x, tourist.transform.position.y);
            Debug.Log("End Level");
            AudioSource.PlayClipAtPoint(scream, transform.position);
            //animate tourist here
            touristDialogue.SetActive(true);
            StartCoroutine(TouristAnimation());
            //animate tourist run
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        pressT.SetActive(true);
        trigger = true;
        if (!soundOff)
        {
            AudioSource.PlayClipAtPoint(huh, transform.position);
        }
        /*//mainCamera.gameObject.transform.position = new Vector2(tourist.transform.position.x, tourist.transform.position.y);
        Debug.Log("End Level");
        AudioSource.PlayClipAtPoint(scream, transform.position);
        //tourist.GetComponent<SpriteRenderer>().flipX = false;
        //animate tourist here
        touristDialogue.SetActive(true);
        StartCoroutine(TouristAnimation());
        //animate tourist run*/
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        pressT.SetActive(false);
    }

    IEnumerator TouristAnimation()
    {
        tourist.GetComponent<Animator>().SetBool("IsScared", true);
        yield return new WaitForSeconds(1);
        Debug.Log("Animating");
        StartCoroutine(EndLevel());
        animating = true;
        Debug.Log(speed);
    }

    IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("new scene");
        SceneManager.LoadScene(5);
    }
}
