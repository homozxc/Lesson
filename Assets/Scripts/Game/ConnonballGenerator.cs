using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnonballGenerator : MonoBehaviour
{
    [SerializeField] private Cannonball _cannonball;
    [SerializeField] private GameObject _cannon;

    public Cannonball SpawnCannonball()
    {
        Vector2 spawnPosition = _cannon.transform.position;
        return Instantiate(_cannonball, spawnPosition, Quaternion.identity);
    }

    public void DeleteCanonballs()
    {
        Cannonball[] cannonballs = FindObjectsOfType<Cannonball>();

        foreach (Cannonball item in cannonballs)
            Destroy(item.gameObject);
    }
}
