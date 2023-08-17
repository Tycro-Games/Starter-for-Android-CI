using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController2D characterController;
    private bool jumping = false;
    private float horizontalMove = 0.0f;

    private bool startedJump = false;
    [SerializeField] private float runSpeed = 40.0f;
    void Start()
    {
        characterController = GetComponent<CharacterController2D>();
    }


    public void Move(InputAction.CallbackContext ctx)
    {
        horizontalMove = ctx.ReadValue<float>() * runSpeed;

    }
    void FixedUpdate()
    {
        if (jumping)
            Debug.Log(jumping);

        characterController.Move(horizontalMove * Time.fixedDeltaTime, false, startedJump);
        startedJump = false;
        jumping = false;

    }
}
