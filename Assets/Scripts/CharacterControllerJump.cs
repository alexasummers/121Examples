using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerJump : MonoBehaviour
{
    public float Speed = 5f;
    public float Gravity = -9.81f; //acceleration of gravity

    private CharacterController _controller; //reference to character controller component
    private Vector3 _velocity; //speed & direction
    private bool _groundedPlayer; //is the player on the ground?
    private float _jumpHeight = 1.0f;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        _groundedPlayer = _controller.isGrounded; //was the character touching the ground during the last frame? Accessing character controller's isGrounded property
        if (_groundedPlayer && _velocity.y < 0)
        {
            _velocity.y = 0f; //if the character was grounded in the last frame and is now moving in a negative velocity (falling down), set the velocity (speed and direction) to zero
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //predefined axes in Unity linked to WASD controlls
        _controller.Move(move * Time.deltaTime * Speed); //moves character in the given direction from our move vector3
        
        _velocity.y += Gravity * Time.deltaTime; //setting velocity in the y direction to the acceleration of gravity in relation to our fps (Time.deltaTime)
        _controller.Move(_velocity * Time.deltaTime); //movement based on velocity
        
        if (move != Vector3.zero) {
            transform.forward = move; //character rotates with directional movement
        }

        if (Input.GetButtonDown("Jump") && _groundedPlayer) //predefined jump in Unity-- paired with space bar
        {
            _velocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * Gravity); //change velocity to reflect a jumping behavior
        }

        _velocity.y += Gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);

    }
}
