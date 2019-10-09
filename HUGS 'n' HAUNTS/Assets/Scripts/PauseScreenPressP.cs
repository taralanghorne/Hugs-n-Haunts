using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreenPressP : MonoBehaviour
{
    public GameObject pauseMenu;
    public Patrol[] werewolves;

    // Start is called before the first frame update
    void Awake()
    {
        //finds each enemy, so we can disable and enable their patrols during pause
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        werewolves = new Patrol[enemies.Length];
        for (int i = 0; i < enemies.Length; ++i)
        {
            werewolves[i] = enemies[i].GetComponent<Patrol>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && !pauseMenu.activeInHierarchy)
        {
            PauseGame();

        }
     
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
        //Disable any scripts that still work while timescale active
        foreach (Patrol script in werewolves)
        {
            script.enabled = false;
        }
        
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        //enable scripts again here
        foreach (Patrol script in werewolves)
        {
            script.enabled = true;
        }

    }
}
