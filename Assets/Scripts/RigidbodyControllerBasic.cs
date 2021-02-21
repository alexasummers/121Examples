using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyControllerBasic : MonoBehaviour
{
    public float Speed = 5f;
    
    private Rigidbody _body;
    private Vector3 _inputs = Vector3.zero;

    void Start()
    {
        _body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _inputs.x = Input.GetAxis("Horizontal");
        _inputs.z = Input.GetAxis("Vertical");
        if (_inputs != Vector3.zero)
            transform.forward = _inputs;
    }

    void FixedUpdate()
    {
        _body.MovePosition(_body.position + _inputs * Speed * Time.deltaTime);
    }
}

