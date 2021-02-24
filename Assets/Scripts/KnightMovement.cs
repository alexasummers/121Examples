using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _walkSpeed;
    [SerializeField] private float _runSpeed;

    private float Gravity = -9.81f;
    private float _jumpHeight = 1.0f;
    private bool _groundedPlayer;
    private Vector3 _velocity;

    private CharacterController _controller;
    private Animator _animator;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
        Movement();


        if (Input.GetButtonDown("Jump") && _groundedPlayer)
        {
            Jump();
        }
        
         _velocity.y += Gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(Attack());
        }

    }

    private void Movement()
    {
        _groundedPlayer = _controller.isGrounded;
        if (_groundedPlayer && _velocity.y < 0)
        {
            _velocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        move = transform.TransformDirection(move);

        _controller.Move(move * Time.deltaTime * _moveSpeed);

        _velocity.y += Gravity * Time.deltaTime;
        _controller.Move(_velocity * Time.deltaTime);

        if (move != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
        {
            Walk();
        }
        else if (move != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
        {
            Run();
        }
        else if(move == Vector3.zero)
        {
            Idle();
        }

    }

    private void Walk()
    {
        _moveSpeed = _walkSpeed;
        _animator.SetFloat("KnightMovement", 0.5f, 0.1f, Time.deltaTime);
    }

    private void Run()
    {
        _moveSpeed = _runSpeed;
        _animator.SetFloat("KnightMovement", 1, 0.1f, Time.deltaTime);
    }

    private void Idle() 
    {
        _animator.SetFloat("KnightMovement", 0, 0.1f, Time.deltaTime);
    }

    private void Jump()
    {
        _velocity.y += Mathf.Sqrt(_jumpHeight * -3.0f * Gravity);
    }

    private IEnumerator Attack()
    {
        _animator.SetLayerWeight(_animator.GetLayerIndex("Attack Layer"), 1);
        _animator.SetTrigger("Attack");

        yield return new WaitForSeconds(0.9f);
        _animator.SetLayerWeight(_animator.GetLayerIndex("Attack Layer"), 0);
    }

}
