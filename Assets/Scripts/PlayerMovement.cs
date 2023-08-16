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

    [SerializeField] private float runSpeed = 40.0f;
    void Start()
    {
        characterController = GetComponent<CharacterController2D>();
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        //add jumping

    }
    public void Move(InputAction.CallbackContext ctx)
    {
        horizontalMove = ctx.ReadValue<float>() * runSpeed;

    }
    void FixedUpdate()
    {
        if (jumping)
            Debug.Log(jumping);

        characterController.Move(horizontalMove * Time.fixedDeltaTime, false, jumping);
        jumping = false;


    }
}
