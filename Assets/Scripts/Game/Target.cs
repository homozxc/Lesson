using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{
    [SerializeField] private GameObject[] _points;
    private Vector3 _targetPosition;
    [SerializeField] private float _speed;
    public static UnityEvent TargetEvent = new UnityEvent();

    private void Update()
    {
        if (Vector3.Distance(transform.position, _targetPosition)<0.1)
        {
            _targetPosition = GetNextPosition();
        }
        Translate();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Cannonball>(out Cannonball cannonball))
        {
            Destroy(gameObject);
            AddSpeed();
            TargetEvent?.Invoke();
        }
    }

    public void Init(GameObject[] points)
    {
        _points = points;
        _targetPosition = GetNextPosition();
    }

    public void Translate()
    {
        transform.Translate((_targetPosition - transform.position) * Time.deltaTime *_speed);
    }

    private void AddSpeed()
    {
        _speed += 0.3f;
    }

    private Vector2 GetNextPosition()
    {
        return _points[Random.Range(0, _points.Length)].transform.position;
    }
}
