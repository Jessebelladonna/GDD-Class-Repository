using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpawnerScript : MonoBehaviour
{

    public GameObject objectToSpawn;
    public PickUpRespawner respawner;

    public void SpawnPickup()
    {
        if(GameObject.FindGameObjectsWithTag(objectToSpawn.tag).Length == 0)
        {
            Instantiate(objectToSpawn, transform.position, transform.rotation);
        }
        else
        {
            Debug.Log("NoSpawn");
        }
    }

}
