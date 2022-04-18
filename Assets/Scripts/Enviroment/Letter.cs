using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : InterestPoint
{
    [SerializeField] private GameObject _letter;
    private Player _player;

    private void Update()
    {
        if (_letter.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                _letter.SetActive(false);
                _player?.EnableMover();
            }
        }
    }

    public override void Interact(Player player)
    {
        _letter.gameObject.SetActive(true);
        _player = player;
        player.DisableMover();
    }
}
