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
    public GameObject touristDialogue;

    void Start()
    {
        door = new Vector3(runPosition.position.x, 0, 0);
        //tourist.GetComponent<SpriteRenderer>().flipX = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        mainCamera.gameObject.transform.position = new Vector3(tourist.transform.position.x, tourist.transform.position.y);
        Debug.Log("End Level");
        AudioSource.PlayClipAtPoint(scream, transform.position);
        //tourist.GetComponent<SpriteRenderer>().flipX = false;
        //animate tourist here
        touristDialogue.SetActive(true);
        StartCoroutine(TouristAnimation());
        StartCoroutine(EndLevel());
        tourist.transform.position = Vector3.MoveTowards(tourist.transform.position, door, speed);
    }

    IEnumerator TouristAnimation()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Animating");
    }

    IEnumerator EndLevel()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("new scene");
        SceneManager.LoadScene(3);
    }
}
