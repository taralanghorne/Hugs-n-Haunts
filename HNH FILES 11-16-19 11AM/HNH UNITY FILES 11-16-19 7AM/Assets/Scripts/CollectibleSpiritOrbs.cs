using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpiritOrbs : MonoBehaviour
{
    public GameObject orb;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.GetComponent<SpiritOrbs>().AddOrb();
            Destroy(orb);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
