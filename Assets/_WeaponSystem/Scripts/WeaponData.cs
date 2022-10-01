using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapons/Weapon")]
public class WeaponData : ScriptableObject
{
  [Header("Info")]
  public new string name;
  public bool isMelee;
  public bool isProjectile;

  [Header("Shooting")]
  public float damage;
  public float maxDistance;
  public float throwForce;
  public float throwUpwardForce;

  [Header("Reloading")]
  public int currentAmmo;
  public int magSize;
  public float fireRate;
  public float reloadTime;

  [Header("Projectile")]
  public GameObject projectile;

  [HideInInspector]
  public bool reloading;

  [Header("Image")]
  public Image img;
}
