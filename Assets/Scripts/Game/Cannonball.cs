using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannonball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _cannonball;
    [SerializeField] private int _pushForce;

    private void Update()
    {
        if (transform.position.y < -20)
            Destroy(gameObject);
    }

    public void Push(Vector2 direction)
    {
        Push(_cannonball,direction * _pushForce);
    }

    private void Push(Rigidbody2D cannonball, Vector2 force)
    {
        cannonball.bodyType = RigidbodyType2D.Dynamic;
        cannonball.mass = 0.01f;
        cannonball.AddForceAtPosition(force, cannonball.transform.position);
    }
}
