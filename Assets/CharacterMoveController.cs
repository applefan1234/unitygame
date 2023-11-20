using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    [SerializeField] private float jumpHeight;
    [SerializeField] private float moveSpeed = 140f;
    private float _moveDir = 1;

    private Rigidbody2D _rigidbody2D;
    private Vector3 _moveVel;
    public float jumpAmount = 10;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;



    void Move()
    {
        _moveVel = _rigidbody2D.velocity;
        _moveVel.x = _moveDir * moveSpeed * Time.fixedDeltaTime;
        _rigidbody2D.velocity = _moveVel;
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


        if (Input.GetButtonDown("Fire1"))
        {
            _rigidbody2D.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
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

