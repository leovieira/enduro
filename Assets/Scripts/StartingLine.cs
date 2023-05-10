using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartingLine : MonoBehaviour {

    public Countdown countdown;
    public CarController carController;
    public TextMeshProUGUI textMain;

    void Start() {
    }

    void Update() {
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.gameObject.name == "CarTrigger") {
            if (countdown.timerIsRunning && countdown.timeRemaining > 0) {
                textMain.text = "Parabéns!";
                textMain.gameObject.SetActive(true);
                carController.stop = true;
            }

            countdown.timerIsRunning = !countdown.timerIsRunning;
        }
    }

}
