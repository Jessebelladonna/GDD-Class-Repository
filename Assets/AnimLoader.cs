using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimLoader : MonoBehaviour
{
    public Animator animator;
    public Rigidbody rigidBody;
    public PlayerInput playerInput;

    void Start()
    {
      rigidBody = GetComponent<Rigidbody>();

      rigidBody.useGravity = false;
    }

    public void OnSelect()
    {
      animator.SetTrigger("Start");
      rigidBody.useGravity = true;
    }
}
