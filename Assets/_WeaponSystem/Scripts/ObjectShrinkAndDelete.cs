using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectShrinkAndDelete : MonoBehaviour
{
  public Vector3 scaleChange = new Vector3(1f, 0f, 1f);

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    gameObject.transform.localScale -= scaleChange * Time.deltaTime;
    if (gameObject.transform.localScale.x <= 0f)
    {
      Destroy(gameObject);
    }
  }
}
