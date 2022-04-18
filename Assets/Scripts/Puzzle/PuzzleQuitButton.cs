using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class PuzzleQuitButton : MonoBehaviour
{
    [SerializeField] private GameObject _room;
    [SerializeField] private GameObject _puzzleMap;

    private void OnMouseDown()
    {
        _room.SetActive(true);
        _puzzleMap.SetActive(false);
    }
}
