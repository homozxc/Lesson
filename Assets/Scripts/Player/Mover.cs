using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider2D))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private SpriteRenderer _renderer;
    private Animator _animator;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        if (horizontal != 0)
        {
            _animator.SetBool("IsWalk", true);
            _renderer.flipX = horizontal < 0;
            Move(horizontal);
        }
        else
        {
            Stop();
        }
    }

    private void Move(float direction)
    {
        if (Mathf.Abs(_rigidbody.velocity.x) < _speed)
            _rigidbody.AddForce(new Vector2(direction, 0) * _speed, ForceMode2D.Impulse);
    }

    public void Stop()
    {
        _rigidbody.velocity = new Vector2(0, _rigidbody.velocity.y);
        _animator.SetBool("IsWalk", false);
    }

}
