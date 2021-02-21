using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerBasic : MonoBehaviour
{
    public float Speed = 5f;

    private CharacterController _controller;
    

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        _controller.Move(move * Time.deltaTime * Speed);
        
        if (move != Vector3.zero) {
            transform.forward = move;
        }
    }
}
