using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableRotate : MonoBehaviour
{

    //update is called once per frame

    private void Update()
    {
        transform.Rotate(new Vector3(20, 25, 40) * Time.deltaTime);
    }
}