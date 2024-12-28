using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   public int score = 0;
   public float timer = 3f;
   public int over = 0;
   public TMP_Text scoretext;
   public TMP_Text timertext;
   public TMP_Text finalscore;
   public GameObject playscreen;
   public GameObject pausemenu;
   public GameObject Left;
   public GameObject Right;
   public void GameOver(){
        over = 1;
        playscreen.SetActive(false);
        Left.SetActive(false);
        Right.SetActive(false);
        finalscore.text = score.ToString();
        pausemenu.SetActive(true);
   }
   public void Restart(){
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
   }
   public void Quit(){
        Application.Quit();
   }
   public void AddScore(int a){
        score += a;
   }
   void Update(){
        scoretext.text = score.ToString();
        timertext.text = ((int)timer).ToString();
        timer -= Time.deltaTime;
        if(timer <= 0){
            GameOver();
        }
   }
}
