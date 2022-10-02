using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.TopDownEngine;

public class AOESpawn : MonoBehaviour
{
  public GameObject aoeObject;
  private GameObject newAOE;

  public float aoeRange = 3f;
  public bool canAOE = true;
  public int damage = 10;

  void Update()
  {
    // Slowly shrink AOE overtime and then delete
    if (newAOE != null)
    {
      //   newAOE.transform.localScale -= scaleChange * Time.deltaTime;
      //   if (newAOE.transform.localScale.x <= 0f)
      //   {
      //     Destroy(newAOE);
      //   }
    }
  }

  void OnCollisionEnter(Collision col)
  {
    if (canAOE == true && col.gameObject.layer != 10)
    {

      // Spawn AOE object
      newAOE = Instantiate(aoeObject, gameObject.transform.position, Quaternion.identity);

      canAOE = false;
    }
  }
}

