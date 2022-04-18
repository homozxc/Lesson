using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Player))]
public class InterectFinder : MonoBehaviour
{
    [SerializeField] private GameObject _interactButton;
    private InterestPoint _interestPoint;
    private Player _player;

    private void Start()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (_interestPoint != null)
            if (Input.GetKeyDown(KeyCode.E))
                _interestPoint.Interact(_player);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent<InterestPoint>(out _interestPoint))
        {
            _interactButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        _interactButton.SetActive(false);
        _interestPoint = null;
    }
}
