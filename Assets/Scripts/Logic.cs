using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.SceneManagement;
public class Logic : MonoBehaviour
{

    public int playerScore = 0;
    public TextMeshProUGUI score;
    public GameObject PauseScreen;

    void Start()
    {
        Time.timeScale = 1.0f;
        PauseScreen.SetActive(false);
    }

    public void addScore()
    {
        playerScore += 1;
        score.text = playerScore.ToString();
    }

    public void pauseMenu()
    { 
        Time.timeScale = 0f;
        PauseScreen.SetActive(true);
    }

    //public void unPause()
    //{
    //    Time.timeScale = 1f;
    //    PauseScreen.SetActive(false);
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale > 0)
                pauseMenu();
            else
                Start();
        }
    }
}
