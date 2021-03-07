using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerGravity : MonoBehaviour
{
    public float Speed = 5f;
    public float Gravity = -9.81f; //acceleration of gravity

    private CharacterController _controller; //reference to character controller component
    private Vector3 _velocity; //velocity is the rate of change of position with respect to time-- composed of speed & direction


    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //axes predefined in Unity
        _controller.Move(move * Time.deltaTime * Speed); //moves our character in the direction specified in the move vector3
        
        _velocity.y += Gravity * Time.deltaTime; //setting velocity in the y direction to the acceleration of gravity in relation to our fps (Time.deltaTime)
        _controller.Move(_velocity * Time.deltaTime);  //movement based on velocity
        
        if (move != Vector3.zero) {
            transform.forward = move; //character rotates with directional movement
        }

    }
}
