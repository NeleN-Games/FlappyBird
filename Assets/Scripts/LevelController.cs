using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public GameObject StartGameCanvas;
    public GameObject GameOverCanvas;

   
    // Start is called before the first frame update

    private void Start()
    {
        Time.timeScale = 0;
    }

    public void GameOver()
    {
        GameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void StartLevel()
    {
        StartGameCanvas.SetActive(false);
        Time.timeScale = 1;
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
