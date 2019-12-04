using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fans : MonoBehaviour
{
    private bool fanOn = true;
    private bool soundOn = false;
    public float delay = 3.0f;
    public GameObject fanObject;
    public GameObject FanTrigger;
    public GameObject wind;
    //public GameObject windP;
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
            StopCoroutine(WaitForTurnOff());
            //sound.Stop();
            //if(soundOn == true)
            //{
            //    AudioSource.PlayClipAtPoint(fan, transform.position);

            //}
            FanTrigger.SetActive(false);
            fanObject.GetComponent<Animator>().SetBool("IsOn", false);
            wind.SetActive(false);
            StartCoroutine(FanTurningOn());
        }
        else if (fanOn)
        {
            if(soundOn == false)
            {
                StopCoroutine(WaitForTurnOn());
                Debug.Log("Playing Sound");
                //sound.Play(); 
                //soundOn = true;
                FanTrigger.SetActive(true);
                fanObject.GetComponent<Animator>().SetBool("IsOn", true);
                wind.SetActive(true);
                //windP.SetActive(true);
                StartCoroutine(FanTurningOff());
            }
        }
    }

    IEnumerator FanTurningOn()
    {
        Debug.Log("FanTurningOn");
        yield return new WaitForSeconds(delay);
        fanOn = true;
        soundOn = false;
        //StartCoroutine(WaitForTurnOn());
    }
    IEnumerator WaitForTurnOn()
    {
        StopCoroutine(FanTurningOn());
        Debug.Log("WaitForTurnOn");
        yield return new WaitForSeconds(1.3f);
        fanOn = true;
        soundOn = false;
    }

    IEnumerator FanTurningOff()
    {
        Debug.Log("FanTurningOff");
        soundOn = true;
        yield return new WaitForSeconds(delay);
        //windP.SetActive(false);
        //sound.Stop();
        //FanTrigger.SetActive(false);
        //wind.SetActive(false);
        fanOn = false;
        //StartCoroutine(WaitForTurnOff());
    }
    IEnumerator WaitForTurnOff()
    {
        StopCoroutine(FanTurningOff());
        Debug.Log("WaitForTurnOff");
        yield return new WaitForSeconds(1.3f);
        fanOn = false;
    }

}
