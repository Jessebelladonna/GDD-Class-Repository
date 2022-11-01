using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUp : MonoBehaviour
{

    public GameObject pickupEffect;
    public float multiplier = 2f;

    public float BobbingSpeed = 3f;
    public float bobbingAmount = 0.2f;

    float defaultPosY = 1.3f;
    float timer = 0;
    
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

        player.transform.localScale *= multiplier;

        Destroy(GameObject.FindWithTag("SpeedUp"));

        Destroy(gameObject);
    }

    void Update()
    {
        timer += Time.deltaTime * BobbingSpeed;
        transform.localPosition = new Vector3(transform.localPosition.x, defaultPosY + Mathf.Sin(timer) * bobbingAmount, transform.localPosition.z);
    }
}
