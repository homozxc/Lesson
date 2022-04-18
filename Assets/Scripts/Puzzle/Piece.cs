using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    [SerializeField] private float _maxX;
    [SerializeField] private float _maxY;
    [SerializeField] private float _minX;
    [SerializeField] private float _minY;

    private Vector3 _targetPosition;
    private bool _isOnPlace;


    private void Start()
    {
        _targetPosition = transform.position;
        transform.position = new Vector2(Random.Range(_minX, _maxX), Random.Range(_minY, _maxY));
    }

    private void Update()
    {
        if (_isOnPlace == false)
        {
            if (Vector2.Distance(transform.position, _targetPosition) < 0.1)
            {
                _isOnPlace = true;
                transform.position = _targetPosition;
                FindObjectOfType<PieceCounter>().AddOnPlaceCount();
            }
        }
    }

    public bool GetOnPlaceState()
    {
        return _isOnPlace;
    }
}
