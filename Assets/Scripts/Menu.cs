using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _aboutPanel;
    [SerializeField] private GameObject _pausePanel;
    [SerializeField] private GameObject _letterPanel;
    private bool _isPaused;

    private void Start()
    {
        Time.timeScale = 1;
        enabled = _pausePanel != null;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && _letterPanel.activeSelf == false)
            Pause();
    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void SwitchPanel()
    {
        _menuPanel.SetActive(!_menuPanel.activeSelf);
        _aboutPanel.SetActive(!_aboutPanel.activeSelf);
    }

    public void Pause()
    {
        _isPaused = !_isPaused;
        _pausePanel.SetActive(_isPaused);
        Time.timeScale = _isPaused ? 0 : 1;
    }
}
