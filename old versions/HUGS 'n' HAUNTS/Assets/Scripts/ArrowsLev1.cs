using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowsLev1 : MonoBehaviour
{
    public GameObject arrowTurnOff;
    public GameObject arrowTurnOn;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        arrowTurnOff.SetActive(false);
        arrowTurnOn.SetActive(true);
    }
}
