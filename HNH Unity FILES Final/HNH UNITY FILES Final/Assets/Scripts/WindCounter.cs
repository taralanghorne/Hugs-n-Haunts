using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindCounter : MonoBehaviour
{
    public ParticleSystem wind;
    public float delay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (wind.isStopped)
        {
            StartCoroutine(FanOn());
        }
    }

    IEnumerator FanOn()
    {
        //Debug.Log("FanTurningOn");
        yield return new WaitForSeconds(delay);
        wind.Play();
    }
}
