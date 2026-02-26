using System;
using UnityEngine;

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
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            if(isGrounded)
            {
                _rb.linearVelocity = new Vector2 (_rb.linearVelocity.x, jump);
                isGrounded = false;
            }
        }

        moveVelocity = 0;

        //Left Right Movement
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) 
        {
            moveVelocity = -GetSpeed();
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) 
        {
            moveVelocity = GetSpeed();
        }

        _rb.linearVelocity = new Vector2 (moveVelocity, _rb.linearVelocity.y);

    }
    
    //Check if Grounded
    private void OnTriggerEnter2D()
    {
        isGrounded = true;
    }

    private float GetSpeed()
    {
        return baseSpeed;
    }
}
