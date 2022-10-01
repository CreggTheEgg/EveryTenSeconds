using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{

    [SerializeField] public float TimeLeft;
    public bool TimerOn = false;

    public TMP_Text TimerTxt;
    void Start()
    {
        TimerOn = true; // turns timer on at start of game
    }

    void FixedUpdate()
    {
        if (TimerOn)
        {
            if (TimeLeft > -1)
            {
                TimeLeft -= Time.deltaTime; // subtracts
                updateTimer(TimeLeft);
            }
            else
            {
                TimeLeft = 10;
                updateTimer(TimeLeft);
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} ", seconds); // first slot is for minutes, 2nd is for seconds
    }
}
