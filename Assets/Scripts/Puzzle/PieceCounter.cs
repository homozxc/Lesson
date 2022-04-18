using UnityEngine;
using UnityEngine.UI;

public class PieceCounter : MonoBehaviour
{
    [SerializeField] private Text _resultText;
    private int _totalPieceCount;
    private int _pieceOnPlaceCount;

    private void Start()
    {
        _pieceOnPlaceCount = 0;
        _totalPieceCount = FindObjectsOfType<Piece>().Length;
    }

    public void AddOnPlaceCount()
    {
        _resultText.text =  $"{++_pieceOnPlaceCount} / {_totalPieceCount} pieces";

        if(_pieceOnPlaceCount >= _totalPieceCount)
            _resultText.text = "Puzzle Complete!";
    }
}

