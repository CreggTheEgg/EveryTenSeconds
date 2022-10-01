using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Spells", menuName = "Spells/Spell")]
public class SpellData : ScriptableObject
{
  [Header("Info")]
  public new string name;
  public GameObject spellObject;

  [Header("Shooting")]
  public float damage;
  public float maxDistance;

  [Header("Reloading")]
  public int currentAmmo;
  public int magSize;
  public float fireRate;
  public float reloadTime;

  [HideInInspector]
  public bool reloading;
}
