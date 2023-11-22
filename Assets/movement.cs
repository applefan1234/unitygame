

using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{





    [SerializeField] private float moveSpeed = 140f;
    private float _moveDir = 1;

    private Rigidbody2D _rigidbody2D;
    private Vector3 _moveVel;
    public float jumpAmount = 10;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;
    public float dashForce = 200f;

    bool onground;


    void Move()
    {
        _moveVel = _rigidbody2D.velocity;
        _moveVel.x = _moveDir * moveSpeed;
        _rigidbody2D.velocity = _moveVel;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with a ground object (you may need to set up a "Ground" layer)
        if (collision.gameObject.tag == "ground")
        {
            onground = true;
        }
    }




    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        Move();
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("button is pressed");

        }

    }

    private void Update()
    {


        if (Input.GetButtonDown("Fire1") && onground == true)
        {
            _rigidbody2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            _rigidbody2D.AddForce(Vector2.right * _moveDir * dashForce, ForceMode2D.Force);
            onground = false;

        }
        if (_rigidbody2D.velocity.y >= 0)
        {
            _rigidbody2D.gravityScale = gravityScale;
        }
        else if (_rigidbody2D.velocity.y < 0)
        {
            _rigidbody2D.gravityScale = fallingGravityScale;
            GetInput();
        }







        void GetInput()
        {

        }


    }
}
