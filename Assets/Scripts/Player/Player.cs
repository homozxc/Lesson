using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Mover))]
[RequireComponent(typeof(InterectFinder))]
public class Player : MonoBehaviour
{
    private Mover _mover;

    private void Start()
    {
        _mover = GetComponent<Mover>();
    }

    public void EnableMover()
    {
        _mover.enabled = true;
    }

    public void DisableMover()
    {
        _mover.Stop();
        _mover.enabled = false;
    }
}
