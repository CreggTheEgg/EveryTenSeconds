using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MoreMountains.TopDownEngine;

public class CountDown : MonoBehaviour
{

  [SerializeField] public float timeLeft;
  public bool timerOn = false;

  public TMP_Text TimerTxt;

  public EnemySpawner spawnManager;

  public static Action swapWeaponAction;

  public GameObject playerInScene;

  void Start()
  {
    timerOn = true; // turns timer on at start of game
    timeLeft = 10f;
  }

  void Update()
  {
    playerInScene = GameObject.Find("Player Character");
  }

  void FixedUpdate()
  {
    if (timerOn)
    {
      if (timeLeft >= 0f)
      {
        timeLeft -= Time.deltaTime; // subtracts
        UpdateTimer(timeLeft);
      }
      else if (playerInScene == null)
      {
        timerOn = false;
      }
      else
      {
        timeLeft = 10f;
        // swapWeaponAction?.Invoke();
        playerInScene.GetComponent<PlayerActions>().SpawnNewWeapon();
        spawnManager.spawnEnemies();
        // updateTimer(timeLeft); - above if statement handles the UpdateTimer method if is above 0 so just set timer to 10
      }
    }
  }

  void UpdateTimer(float currentTime)
  {
    currentTime += 1f;

    float seconds = Mathf.FloorToInt(currentTime % 60f);

    TimerTxt.text = string.Format("{00:00} ", seconds); // first slot is for minutes, 2nd is for seconds
  }
}
