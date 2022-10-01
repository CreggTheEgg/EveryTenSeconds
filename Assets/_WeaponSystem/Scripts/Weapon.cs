using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  [Header("References")]
  public WeaponData weaponData;

  private void Start()
  {
    PlayerActions.attackInput = FireWeapon;
  }

  private void Update()
  {

  }

  public void SwingWeapon()
  {

  }

  public void FireWeapon()
  {
    if (weaponData.isProjectile)
    {
      GameObject newProjectile = Instantiate(weaponData.projectile, transform.position, Quaternion.identity);
      Rigidbody projectileRb = newProjectile.GetComponent<Rigidbody>();

      Vector3 forceToAdd = transform.forward * weaponData.throwForce + transform.up * weaponData.throwUpwardForce + projectileRb.velocity;

      projectileRb.AddForce(forceToAdd, ForceMode.Impulse);
    }

    Debug.Log("Weapon Fired");
  }
}
