using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibeHealth : MonoBehaviour
{
    public GameObject player;
    public GameObject health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.GetComponent<SpooksterHealth>().AddHealth();
            Destroy(health);
        }
    }
}
