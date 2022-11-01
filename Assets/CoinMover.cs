using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMover : MonoBehaviour
{
    
    public GameObject coin;
    public PickUpRespawner pickUpRespawner;
    
    public Vector3 startPosition;
    public Vector3 newPosition1;
    public Vector3 newPosition2;
    public Vector3 newPosition3;
    


    void Start()
    {
        transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
        coin.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);

        Debug.Log("Start Position");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            pickUpRespawner.Pickup();
            
            if (coin.transform.position == startPosition)
            {
                transform.position = new Vector3(newPosition1.x, newPosition1.y, newPosition1.z);
                coin.transform.position = new Vector3(newPosition1.x, newPosition1.y, newPosition1.z);
            }
            else if (coin.transform.position == newPosition1)
            {
                transform.position = new Vector3(newPosition2.x, newPosition2.y, newPosition2.z);
                coin.transform.position = new Vector3(newPosition2.x, newPosition2.y, newPosition2.z);
            }
            else if (coin.transform.position == newPosition2)
            {
                transform.position = new Vector3(newPosition3.x, newPosition3.y, newPosition3.z);
                coin.transform.position = new Vector3(newPosition3.x, newPosition3.y, newPosition3.z);
            }
            else if (coin.transform.position == newPosition3)
            {
                transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
                coin.transform.position = new Vector3(startPosition.x, startPosition.y, startPosition.z);
            }
        }
    }
}
