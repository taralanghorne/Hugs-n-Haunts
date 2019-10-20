using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpiritOrbs_level2 : MonoBehaviour
{
    public GameObject orb;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.GetComponent<SpiritOrbs5>().AddOrb();
            Destroy(orb);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
