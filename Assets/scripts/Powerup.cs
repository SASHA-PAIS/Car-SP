using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    public float multiplier = 1.4f;
    public GameObject bomb;

    // public GameObject pickupEffect;

     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Pickup();
        
        }
    }

    void Pickup()
    {
        //Spawn a cool effect

        //Apply effect to the player

        //Remove power up object

        //Instantiate(pickupEffect, transform.position, transform.rotation);

        Destroy(bomb, 2f);

        //player.transform.localScale *= multiplier;

        //PlayerStats stats = player.GetComponent<PlayerStats>();
        //stats.health = stats.health * multiplier;

        Destroy(gameObject);

    }
}
