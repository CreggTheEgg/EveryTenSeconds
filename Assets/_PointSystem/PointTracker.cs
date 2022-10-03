using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointTracker : MonoBehaviour
{
  public TMP_Text pointText;
  public int currentPoints = 0;
  public int timerPoints = 0;

  // Start is called before the first frame update
  void Start()
  {
    pointText = GetComponent<TMP_Text>();
    MoreMountains.TopDownEngine.GameManager.Instance.Points = 0;
    currentPoints = MoreMountains.TopDownEngine.GameManager.Instance.Points;
  }

  // Update is called once per frame
  void Update()
  {
    Debug.Log("TimerPoints "+ timerPoints);
    Debug.Log("Game engine points "+ MoreMountains.TopDownEngine.GameManager.Instance.Points);
    Debug.Log("Total Points "+timerPoints + MoreMountains.TopDownEngine.GameManager.Instance.Points);
    currentPoints = timerPoints + MoreMountains.TopDownEngine.GameManager.Instance.Points;

    if (pointText != null)
    {
      pointText.text = "Points: " + currentPoints.ToString();
    }
    else
    {
      pointText.text = "MISSING TEXT OBJECT";
    }
  }

  public void AddTimerPoints(int totalTime)
  {
    timerPoints = totalTime;
  }
}
