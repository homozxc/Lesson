using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameQuitButton : MonoBehaviour
{
    [SerializeField] private GameObject _map;
    [SerializeField] private GameObject _room;
    [SerializeField] private TargetGenerator _targetGenerator;
    [SerializeField] private ConnonballGenerator _connonballGenerator;


    private void OnMouseDown()
    {
        _map.SetActive(false);
        _room.SetActive(true);
        _targetGenerator.DeleteTargets();
        _targetGenerator.enabled = false;
        _connonballGenerator.DeleteCanonballs();
    }
}
