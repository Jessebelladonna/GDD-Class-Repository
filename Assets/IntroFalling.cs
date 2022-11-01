using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroFalling : MonoBehaviour
{

    public PlayerController playerController;

    void Start()
    {
        playerController = GetComponent<PlayerController>();
    }

    void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Level"))
        {
            playerController.enabled = true;
            
            Destroy(this);
        }
    }
}
