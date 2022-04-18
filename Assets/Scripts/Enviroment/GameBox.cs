using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameBox : InterestPoint
{
    [SerializeField] private GameObject _map;
    [SerializeField] private GameObject _room;
    [SerializeField] private GameObject _camera;
    public override void Interact(Player player)
    {
        _map.SetActive(true);
        _room.SetActive(false);
        _camera.GetComponent<TargetGenerator>().enabled = true;
    }
}
