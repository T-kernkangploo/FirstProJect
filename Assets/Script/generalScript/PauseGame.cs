using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private static bool GamePause = false;
    [SerializeField] private GameObject pauseGameUI;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseGameUI.SetActive(false);
        Time.timeScale = 1f;
        GamePause = false;
    }
    public void Pause()
    {
        pauseGameUI.SetActive(true);
        Time.timeScale = 0f;
        GamePause = true;
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

}