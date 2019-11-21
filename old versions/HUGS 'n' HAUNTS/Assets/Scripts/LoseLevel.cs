using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseLevel : MonoBehaviour
{
    public GameObject loseText;

    private void Update()
    {
        if (SpooksterHealth.lose==true)
        {
            Debug.Log("lose text");
            loseText.SetActive(true);
            StartCoroutine(Lose());
        }
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(4);
    }
}
