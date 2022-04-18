using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    [SerializeField] private int _targetCount;
    [SerializeField] private GameObject[] _points;
    [SerializeField] private Target _target;
    [SerializeField] private float _respawnTime;
    private float _currentTime;

    private void Update()
    {
        _currentTime += Time.deltaTime;
        if(_currentTime >= _respawnTime)
        {
            SpawnTargets(_targetCount);
            _currentTime = 0;
        }
    }

    private void Start()
    {
        SpawnTargets(_targetCount);
    }

    private void SpawnTargets(int count)
    {
        for (int i = 0; i < count; i++)
        {
            SpawnTarget().Init(_points);
        }
    }

    private Target SpawnTarget()
    {
        Vector2 spawnPosition = _points[Random.Range(0, _points.Length)].transform.position;
        return Instantiate(_target, spawnPosition, Quaternion.identity);
    }

    public void DeleteTargets()
    {
        Target[] targets = FindObjectsOfType<Target>();

        foreach(Target item in targets)
        {
            Destroy(item.gameObject);
        }
    }
}
