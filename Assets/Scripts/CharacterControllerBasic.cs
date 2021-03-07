using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerBasic : MonoBehaviour
{
    public float Speed = 5f;

    private CharacterController _controller;
    

    void Start()
    {
        _controller = GetComponent<CharacterController>(); //reference to the character controller component
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //predefined axes in Unity linked to WASD controlls
        _controller.Move(move * Time.deltaTime * Speed); //moves character in the given direction from our move vector3
        
        if (move != Vector3.zero) {
            transform.forward = move; //character rotates with directional movement
        }
    }
}
