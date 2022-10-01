using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  [Header("References")]

  public WeaponData weaponData;

  private void Start()
  {
    // PlayerAttack.attackInput += Attack;
    // PlayerAttack.swapWeaponAction += SwapWeaponData;
  }

  public void Attack()
  {
    //Check if can attack
    //Perform weapon attack
    //OnWeaponShot(); - use this for particles/sounds/lights
  }

  private void Update()
  {

  }

  private void OnWeaponShot()
  {

  }

}
