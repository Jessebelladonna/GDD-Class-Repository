using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRespawner : MonoBehaviour
{

    public GameObject pickupEffect;
    public bool needRespawn = false;
    public Component[] pickUpSpawner;

    void Awake()
    {
        pickUpSpawner = GetComponentsInChildren<PickUpSpawnerScript>();
        foreach(PickUpSpawnerScript spawner in pickUpSpawner)
            spawner.SpawnPickup();
    }

    public void Pickup()
    {
        pickUpSpawner = GetComponentsInChildren<PickUpSpawnerScript>();
        foreach(PickUpSpawnerScript spawner in pickUpSpawner)
            spawner.SpawnPickup();
    }

}
