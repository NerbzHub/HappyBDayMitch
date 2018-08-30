using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterNTimer : MonoBehaviour {

    public static int Counter;
    public Text Score;
    public Text timer;
    public Text hapbdayText;

    private float timerValue;
    private string scoreTemplate;
    private string timerTemplate;

    // Use this for initialization
    void Start ()
    {
        scoreTemplate = "Score: ";
        timerTemplate = "Timer: ";
        Counter = 0;
        timerValue = 0.0f;
	}

    private void Update()
    {
        Score.text = scoreTemplate + Counter.ToString();
        timer.text = timerTemplate + Mathf.Round(timerValue).ToString();
        

        if(Counter >= 20)
        {
            hapbdayText.text = "YOU WIN!";
        }
        else
        {
            timerValue += Time.deltaTime;
        }
    }
}
