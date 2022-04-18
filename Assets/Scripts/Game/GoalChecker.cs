using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalChecker : MonoBehaviour
{
    [SerializeField] Text _targetText;
    private int _points = 0;
    private int _goalPoints = 15;

    private void Start()
    {
        Target.TargetEvent.AddListener(AddPoint);
    }

    private void AddPoint()
    {
        if (_points >= _goalPoints)
            _targetText.text = "Mission Compleated";
        else
            _targetText.text = $"{++_points} / {_goalPoints} targets";
    }
}
