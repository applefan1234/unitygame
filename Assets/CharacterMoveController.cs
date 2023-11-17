using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    [SerializeField] private float jumpHeight;
    [SerializeField] private float moveSpeed = 140f;
    private float _moveDir;

    private Rigidbody2D _rigidbody2D;
    private Vector3 _moveVel;



    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetInput();
    }

    private void FixedUpdate()
    {
        Move();
    }

  

    private void Move()
    {
        _moveVel = _rigidbody2D.velocity;
        _moveVel.x = _moveDir * moveSpeed * Time.fixedDeltaTime;
        _rigidbody2D.velocity = _moveVel;
    }


    void GetInput()
    {
        _moveDir = Input.GetAxisRaw("Vertical"); 
    }


}

