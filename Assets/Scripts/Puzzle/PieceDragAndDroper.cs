using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceDragAndDroper : MonoBehaviour
{
    private Piece _selectedPiece;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            TryCatch();

        if (Input.GetMouseButtonUp(0))
            Drop();
        
        if(_selectedPiece != null)
            Move();
    }

    private void TryCatch()
    {
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if(hit && hit.transform.TryGetComponent<Piece>(out Piece piece))
            if(piece.GetOnPlaceState() == false)
                _selectedPiece = piece;
    }

    private void Drop()
    {
        _selectedPiece = null;
    }

    private void Move()
    {
        if(_selectedPiece.GetOnPlaceState() == false)
            _selectedPiece.transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
