using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointTracker : MonoBehaviour
{
  public TMP_Text pointText;
  public int currentPoints = 0;

  // Start is called before the first frame update
  void Start()
  {
    pointText = GetComponent<TMP_Text>();
    currentPoints = MoreMountains.TopDownEngine.GameManager.Instance.Points;
  }

  // Update is called once per frame
  void Update()
  {
    currentPoints = MoreMountains.TopDownEngine.GameManager.Instance.Points;

    if (pointText != null)
    {
      pointText.text = "Points: " + currentPoints.ToString();
    }
    else
    {
      pointText.text = "MISSING TEXT OBJECT";
    }
  }
}
