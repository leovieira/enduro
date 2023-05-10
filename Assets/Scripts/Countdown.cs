using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour {

    public CarController carController;
    public TextMeshProUGUI textCountdown;
    public TextMeshProUGUI textMain;
    public float timeRemaining;
    public bool timerIsRunning;

    void Start() {
    }

    void Update() {
        if (timerIsRunning) {
            if (timeRemaining > 0) {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            } else {
                GameOver();
                timeRemaining = 0;
                timerIsRunning = false;
            }
        }
    }

    void DisplayTime(float timeToDisplay) {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        textCountdown.text = string.Format("Tempo: {0:00}:{1:00}", minutes, seconds);
    }

    void GameOver() {
        carController.stop = true;
        textMain.text = "Game Over!";
        textMain.gameObject.SetActive(true);
    }

}
