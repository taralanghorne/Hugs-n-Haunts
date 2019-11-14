using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickToNewScene : MonoBehaviour
{
    //public GameObject buttonClicking;
    public int sceneNumber; //number of scene you want to go to

    public void ClickNewScene()
    {
        SceneManager.LoadScene(sceneNumber);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
