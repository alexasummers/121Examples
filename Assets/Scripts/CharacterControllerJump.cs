using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerJump : MonoBehaviour
{
    public float Speed = 5f;
    public float Gravity = -9.81f;

    private CharacterController _controller;
    private Vector3 _velocity;
    private bool _groundedPlayer;
    private float _jumpHeight = 1.0f;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        _groundedPlayer = _controller.isGrounded;
        if (_groundedPlayer && _velocity.y < 0)
        {
            _velocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * Speed);
        
        _velocity.y += Gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime); 
        
        if (move != Vector3.zero) {
            transform.forward = move;
        }

        if (Input.GetButtonDown("Jump") && _groundedPlayer)
        {
            _velocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * Gravity);
        }

        _velocity.y += Gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);

    }
}
