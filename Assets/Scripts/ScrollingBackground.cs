using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
  private Rigidbody2D rigidbody2D;

  // Use this for initialization
  void Start()
  {
    rigidbody2D = GetComponent<Rigidbody2D>();
    rigidbody2D.velocity = new Vector2(-1.5f, 0);
  }

  // Update is called once per frame
  void Update()
  {
  }
}
