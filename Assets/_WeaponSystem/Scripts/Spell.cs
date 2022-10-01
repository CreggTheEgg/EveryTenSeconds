using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
  [Header("References")]
  [SerializeField] SpellData spellData;

  public List<SpellData> spells = new List<SpellData>();

  private void Start()
  {
    PlayerAttack.attackInput += Attack;
    PlayerAttack.swapSpellInput += SwapSpellData;
  }

  private bool CanShoot() => true;

  public void Attack()
  {
    // if (spellData.currentAmmo > 0)
    {
      if (CanShoot())
      {
        // Instantiate Object
        OnWeaponShot();
      }
    }
  }

  private void Update()
  {

  }

  private void OnWeaponShot()
  {

  }

  private void SwapSpellData()
  {
    //swap spell data with random from list
    spellData = spells[Random.Range(0, spells.Count)];
  }
}
