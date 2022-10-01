using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
  public static Action attackInput;

  public GameObject itemHolder;

  public GameObject currentWeapon;
  public List<GameObject> weapons = new List<GameObject>();

  private GameObject newWeapon;

  private void Start()
  {
    newWeapon = Instantiate(weapons[UnityEngine.Random.Range(0, weapons.Count)], itemHolder.transform.position, itemHolder.transform.rotation);
    CountDown.swapWeaponAction += SpawnNewWeapon;
  }

  private void Update()
  {
    newWeapon.transform.parent = itemHolder.transform;
    // currentWeapon = newWeapon;

    // test weapon swap with keybind for quick testing
    if (Input.GetKeyDown(KeyCode.E))
    {
      SpawnNewWeapon();
    }

    // Player input to attack with weapon
    if (Input.GetMouseButtonDown(0))
    {
      attackInput?.Invoke();
      Debug.Log("Player attack input");
    }
  }
  private void SpawnNewWeapon()
  {
    Destroy(newWeapon);
    newWeapon = Instantiate(weapons[UnityEngine.Random.Range(0, weapons.Count)], itemHolder.transform.position, itemHolder.transform.rotation);
    // swapWeaponAction?.Invoke();
  }
}
