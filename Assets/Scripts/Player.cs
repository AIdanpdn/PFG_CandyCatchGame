using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Player : MonoBehaviour
{

    [SerializeField] GameObject _self;
    [SerializeField] Rigidbody2D _rb;

    private Candy _candy;
    public float _moveSpeed = 0.0f;

    public float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        float hMove = horizontalInput * _moveSpeed * Time.deltaTime;

        _rb.velocity = new Vector2(hMove, _rb.velocity.y);
    }


}
