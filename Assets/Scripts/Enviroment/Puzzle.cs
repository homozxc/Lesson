using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : InterestPoint
{
    [SerializeField] private GameObject _puzzleMap;
    [SerializeField] private GameObject _room;

    public override void Interact(Player player)
    {
        _puzzleMap.SetActive(true);
        _room.SetActive(false);
    }
}
