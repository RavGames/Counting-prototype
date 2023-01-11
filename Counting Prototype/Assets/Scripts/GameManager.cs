using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timerText;
    [SerializeField] private bool isPaused = false;
    [SerializeField] private GameObject startGameTitle;
    [SerializeField] private GameObject stopGameTitle;
    private bool isGameActive;
    private bool isTimerStarted;
    private float timer;





    private void Start() 
    {
        isTimerStarted = false;
    }

    private void Update()
    {
        TimerTick();

        PauseButton();

    }

    private void TimerTick()
    {
        if (isTimerStarted)
        {
            timer -= Time.deltaTime;
            timerText.text = "Timer: " + Mathf.Round(timer);
            if (timer <= 0)
            {
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        
    }

    private void PauseButton()
    {
        if (Input.GetKeyUp(KeyCode.P))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        if(!isPaused)
        {
            isPaused = true;
            Time.timeScale = 0;
        }   
        else
        {
            isPaused = false;
            Time.timeScale = 1;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }



public void StartCOuntDown(float countDown)
{
    timer = countDown;
    timerText.text = "Timer: "+ Mathf.Round(timer);
}



}//CLASS

