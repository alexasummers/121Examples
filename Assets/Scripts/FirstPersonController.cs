using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonController : MonoBehaviour
{
    private float _moveSpeed;
    private float _walkSpeed = 5f;
    private float _runSpeed = 10f;

    private float Gravity = -9.81f; //acceleration of gravity
    private float _jumpHeight = 1.0f;
    private bool _groundedPlayer;
    private Vector3 _velocity;

    private CharacterController _controller; //references Character Controller component

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Movement(); //see function on line 45


        if (Input.GetButton("Jump") && _groundedPlayer) //predefined jump in Unity-- paired with space bar
        {
            Jump(); //defined on line 94
        }
        
         _velocity.y += Gravity * Time.deltaTime; //setting velocity in the y direction to the acceleration of gravity in relation to our fps (Time.deltaTime)
        _controller.Move(_velocity * Time.deltaTime); //movement based on velocity


    }

    private void Movement()
    {
        _groundedPlayer = _controller.isGrounded; //was the character touching the ground during the last frame? Accessing character controller's isGrounded property
        if (_groundedPlayer && _velocity.y < 0)
        {
            _velocity.y = 0f; //if the character was grounded in the last frame and is now moving in a negative velocity (falling down), set the velocity (speed and direction) to zero
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //predefined axes in Unity linked to WASD controlls
        move = transform.TransformDirection(move); //changes direction 

        _controller.Move(move * Time.deltaTime * _moveSpeed);

        _velocity.y += Gravity * Time.deltaTime; //setting velocity in the y direction to the acceleration of gravity in relation to our fps (Time.deltaTime)
        _controller.Move(_velocity * Time.deltaTime); //movement based on velocity

        if (move != Vector3.zero && !Input.GetKey(KeyCode.LeftShift)) //if the character is moving AND the left shift key is not pressed, use the walking speed
        {
            Walk(); //defined on line 76
        }
        else if (move != Vector3.zero && Input.GetKey(KeyCode.LeftShift)) //if the character is mpoving and the left shift key IS pressed, use the running speed
        {
            Run(); //defined on line 82
        }
        else if(move == Vector3.zero) //if the character is not moving, stand in idle
        {
            Idle(); //defined on line 88
        }

    }

    private void Walk()
    {
        _moveSpeed = _walkSpeed; //set my movement to walking speed
    }

    private void Run()
    {
        _moveSpeed = _runSpeed; //set my movement to running speed
    }

    private void Idle() 
    {
        _moveSpeed = 0;
    }

    private void Jump()
    {
        _velocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * Gravity); //change velocity to reflect a jumping behavior
    }

}
