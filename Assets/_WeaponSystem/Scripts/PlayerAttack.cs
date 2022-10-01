using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
  public static Action attackInput;
  public static Action swapSpellInput;

  private void Update()
  {
    // if (Input.GetMouseButton(0))
    // {
    //   attackInput?.Invoke();
    // }

    if (Input.GetKeyDown(KeyCode.E))
    {
      swapSpellInput?.Invoke();
    }
  }
}
