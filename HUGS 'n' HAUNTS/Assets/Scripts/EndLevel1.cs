using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel1 : MonoBehaviour
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

    public GameObject doorClosed;
    public GameObject doorOpen;
    public AudioClip doorCreak;
    public GameObject endTrigger;
    public GameObject endArrow;
    public GameObject endDialogue;

    void Start()
    {
        door = new Vector3(runPosition.position.x, runPosition.position.y, 0);
        //tourist.GetComponent<SpriteRenderer>().flipX = true;
    }

    private void Update()
    {
        if (animating)
        {
            //step = speed * Time.deltaTime;
            tourist.GetComponent<SpriteRenderer>().flipX = false;
            tourist.transform.position = Vector3.MoveTowards(tourist.transform.position, door, speed);
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
    }

    void OnTriggerExit2D(Collider2D other)
    {
        pressT.SetActive(false);
        trigger = false;
    }

    IEnumerator TouristAnimation()
    {

        tourist.GetComponent<Animator>().SetBool("IsScared", true);
        yield return new WaitForSeconds(2);
        Debug.Log("Animating");
        StartCoroutine(EndLevel());
        animating = true;
        Debug.Log(speed);
    }

    IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(1);
        //Debug.Log("new scene");
        //SceneManager.LoadScene(3);
        AudioSource.PlayClipAtPoint(doorCreak, transform.position);
        tourist.SetActive(false);
        doorClosed.SetActive(false);
        doorOpen.SetActive(true);
        endArrow.SetActive(true);
        endTrigger.SetActive(true);
        AudioSource.PlayClipAtPoint(huh, transform.position);
        endDialogue.SetActive(true);
    }
}
