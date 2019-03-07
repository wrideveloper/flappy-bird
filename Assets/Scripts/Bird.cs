using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{

  private Rigidbody2D rigidbody2D;
  private Animator animator;
  private bool isDead = false;

  public Text gameOverText;

  // Use this for initialization
  void Start()
  {
    rigidbody2D = GetComponent<Rigidbody2D>();
    animator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    if (!isDead && Input.GetMouseButtonDown(0))
    {
      animator.SetTrigger("Flap");
      rigidbody2D.velocity = Vector2.zero;
      rigidbody2D.AddForce(new Vector2(0, 200));
    }
    else if (isDead && Input.GetMouseButtonDown(0))
    {
      SceneManager.LoadScene("SampleScene");
    }
  }

  void OnCollisionEnter2D()
  {
    animator.SetTrigger("Die");
    isDead = true;
    gameOverText.gameObject.SetActive(true);
  }
}
