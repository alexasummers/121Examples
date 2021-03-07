using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyControllerJump : MonoBehaviour
{
    public float Speed = 5f;
    public float JumpHeight = 2f;

    private Rigidbody _body; //references Rigidbody controller component
    private Vector3 _inputs = Vector3.zero;

    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    void Update()
    {

        _inputs.x = Input.GetAxis("Horizontal"); //accessing predefined Unity axes
        _inputs.z = Input.GetAxis("Vertical"); //accessing predefined Unity axes
        if (_inputs != Vector3.zero)
            transform.forward = _inputs; //character rotates with directional movement

        if (Input.GetButtonDown("Jump")) //accessing predefined Unity jump functionality-- space bar
        {
            _body.AddForce(Vector3.up * Mathf.Sqrt(JumpHeight * -2f * Physics.gravity.y), ForceMode.VelocityChange); //force applied continuously along direction of the force vector (Vector3.up). ForceMode.VelocityChange applies our change to the velocity
        }
    }


    void FixedUpdate() //updates physics calculations-- called every fixed frame rate.
    {
        _body.MovePosition(_body.position + _inputs * Speed * Time.fixedDeltaTime); //New position for rigidbody-- smooth movement between frames
    }
}
