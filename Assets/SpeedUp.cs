using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    
    public GameObject pickupEffect;
    public float multiplier = 2f;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        PlayerController playerController = player.GetComponent<PlayerController>();
        playerController.speed *= multiplier;

        Destroy(GameObject.FindWithTag("SizeUp"));

        Destroy(gameObject);
    }
}
