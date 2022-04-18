using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    [SerializeField] private Text _timerText;
    [SerializeField] private float _time;

    private void Update()
    {
        
        _timerText.text = $"{_time -= Time.deltaTime}";

        if (_time < 0)
            SceneManager.LoadScene("GameOver");
    }
}
