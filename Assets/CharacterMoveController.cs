using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    [SerializeField] private float jumpHeight;
    [SerializeField] private float moveSpeed = 140f;
    private float _moveDir = 1 ;

    private Rigidbody2D _rigidbody2D;
    private Vector3 _moveVel;
    public float jumpAmount = 10;



    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {



        if (Input.GetButtonDown("Fire1"))
        {
            _rigidbody2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
        }
        GetInput();
    }

    private void FixedUpdate()
    {
        Move();
        if (Input.GetButtonDown("Fire1")){
            Debug.Log("button is pressed");
        
        }

    }



    private void Move()
    {
        _moveVel = _rigidbody2D.velocity;
        _moveVel.x = _moveDir * moveSpeed * Time.fixedDeltaTime;
        _rigidbody2D.velocity = _moveVel;
    }


    void GetInput()
    {
        
    }


}

