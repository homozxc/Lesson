using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private bool _isUp;
    [SerializeField] private Cannon _cannon;

    private void OnMouseDown()
    {
        if(_isUp == true)
        {
            _cannon.AddYForce();
        }
        else
        {
            _cannon.TakeYForce();
        }
    }
}
