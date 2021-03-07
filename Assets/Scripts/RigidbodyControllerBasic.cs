using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyControllerBasic : MonoBehaviour
{
    public float Speed = 5f;
    
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
    }

    void FixedUpdate() //updates physics calculations-- called every fixed frame rate.
    {
        _body.MovePosition(_body.position + _inputs * Speed * Time.deltaTime); //New position for rigidbody-- smooth movement between frames
    }
}

