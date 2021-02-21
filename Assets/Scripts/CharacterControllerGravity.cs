using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerGravity : MonoBehaviour
{
    public float Speed = 5f;
    public float Gravity = -9.81f;

    private CharacterController _controller;
    private Vector3 _velocity;


    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * Speed);
        
        _velocity.y += Gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime); 
        
        if (move != Vector3.zero) {
            transform.forward = move;
        }

    }
}
