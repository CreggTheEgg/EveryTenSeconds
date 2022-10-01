using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
  // public static Action swapWeaponAction;

  public GameObject itemHolder;

  public GameObject currentWeapon;
  public List<GameObject> weapons = new List<GameObject>();

  private GameObject newWeapon;

  public CountDown cdTimer;

  private void Start()
  {
    newWeapon = Instantiate(weapons[0], itemHolder.transform.position, Quaternion.identity);

    CountDown.swapWeaponAction += SpawnNewWeapon;
  }

  private void Update()
  {
    // currentWeapon = newWeapon;

    // test weapon swap with keybind for quick testing
    if (Input.GetKeyDown(KeyCode.E))
    {
      SpawnNewWeapon();
    }



    newWeapon.transform.parent = itemHolder.transform;
  }

  private void SpawnNewWeapon()
  {
    Destroy(newWeapon);
    newWeapon = Instantiate(weapons[UnityEngine.Random.Range(0, weapons.Count)], itemHolder.transform.position, Quaternion.identity);
    // swapWeaponAction?.Invoke();
  }
}
