using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float baseSpeed;
    [SerializeField] private float jump;
    private Rigidbody2D _rb;
    
    private float moveVelocity;

    //Grounded Vars
    bool isGrounded = true;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update () 
    {
        //Jumping
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.wKey.wasPressedThisFrame) 
        {
            if(isGrounded)
            {
                _rb.linearVelocity = new Vector2 (_rb.linearVelocity.x, jump);
                isGrounded = false;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed) 
        {
            moveVelocity = -GetSpeed();
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed) 
        {
            moveVelocity = GetSpeed();
        }

        _rb.linearVelocity = new Vector2 (moveVelocity, _rb.linearVelocity.y);

    }
    
    //Check if Grounded
    private void OnTriggerEnter2D(Collider2D other)
    {
        isGrounded = true;
    }

    private float GetSpeed()
    {
        return baseSpeed;
    }
}
