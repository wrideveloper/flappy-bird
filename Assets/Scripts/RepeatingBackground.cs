using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
  private BoxCollider2D groundCollider;
  private float horizontalSize;

  // Use this for initialization
  void Start()
  {
    groundCollider = GetComponent<BoxCollider2D>();
    horizontalSize = groundCollider.size.x;
  }

  // Update is called once per frame
  void Update()
  {
    if (transform.position.x < -horizontalSize)
      RepositionBackground();
  }

  void RepositionBackground()
  {
    Vector2 offset = new Vector2(horizontalSize * 2, 0);
    transform.position = (Vector2)transform.position + offset;
  }
}
