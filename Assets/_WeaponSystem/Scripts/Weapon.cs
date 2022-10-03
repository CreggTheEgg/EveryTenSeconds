using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  [Header("References")]
  public WeaponData weaponData;
  public AudioSource audioSource;

  private void Start()
  {
    PlayerActions.attackInput = FireWeapon;
    audioSource = gameObject.GetComponent<AudioSource>();
  }

  private void Update()
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

    if (weaponData.isMelee)
    {
      // StartCoroutine(SwingSword());
      PlayMeleeAnimation(gameObject.GetComponent<Animator>());
    }

    if (weaponData.useParticle)
    {
      //TODO: Play particle effect
      ParticleSystem ps = Instantiate(weaponData.particleSystem, transform.position, transform.rotation);
      Debug.Log("Particle Spawned");
      weaponData.particleSystem.Play();
    }

    RandomSoundness();
  }

 
  void RandomSoundness()
  {
    audioSource.clip = weaponData.sounds[Random.Range(0, weaponData.sounds.Length)];
    audioSource.Play();
  }

  // IEnumerator SwingSword()
  // {
  //   if (gameObject.GetComponent<Animator>() != null)
  //   {
  //     gameObject.GetComponent<Animator>().Play("SwingSword");
  //     yield return new WaitForSeconds(1f);
  //     gameObject.GetComponent<Animator>().Play("SwordIdle");
  //   }
  // }

  public void PlayMeleeAnimation(Animator anim)
  {

    if (gameObject.GetComponent<Animator>() != null)
    {
      // gameObject.GetComponent<Animator>().Play("SwingSword");
      gameObject.GetComponent<Animator>().SetTrigger("Attack");
      // gameObject.GetComponent<Animator>().ResetTrigger("Attack");
    }
  }
}
