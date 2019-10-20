using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fans : MonoBehaviour
{
    private bool fanOn = true;
    private bool soundOn = true;
    public int delay = 3;
    public GameObject fanObject;
    public GameObject FanTrigger;
    public GameObject wind;
    private AudioSource sound;
    public AudioClip fan; //when fan is on

    // Start is called before the first frame update
    void Awake()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!fanOn)
        {
            sound.Stop();
            if(soundOn == true)
            {
                AudioSource.PlayClipAtPoint(fan, transform.position);

            }
            FanTrigger.SetActive(false);
            wind.SetActive(false);
            StartCoroutine(FanTurningOn());
        }
        else if (fanOn)
        {
            if(soundOn == true)
            {
                AudioSource.PlayClipAtPoint(fan, transform.position);

            }
            FanTrigger.SetActive(true);
            wind.SetActive(true);
            StartCoroutine(FanTurningOff());
        }
    }

    IEnumerator FanTurningOn()
    {
        yield return new WaitForSeconds(delay);
        soundOn = true;
        StartCoroutine(WaitForTurnOn());
    }
    IEnumerator WaitForTurnOn()
    {
        yield return new WaitForSeconds(1.3f);
        fanOn = true;
    }

    IEnumerator FanTurningOff()
    {
        yield return new WaitForSeconds(delay);
        StartCoroutine(WaitForTurnOff());
        soundOn = false;
    }
    IEnumerator WaitForTurnOff()
    {
        yield return new WaitForSeconds(1.3f);
        fanOn = false;
    }

}
