using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  [SerializeField] private float initialVelocity = 4f;
  [SerializeField] private float velocityMultiplier = 1.1f;
  private Rigidbody2D ballRb;
  // Start is called before the first frame update
  void Start()
  {
    ballRb = GetComponent<Rigidbody2D>();
    Launch();
  }

  private void Launch()
  {
    float xVelocity = Random.Range(0, 2) == 0 ? -1 : 1;
    float yVelocity = Random.Range(0, 2) == 0 ? -1 : 1;
    ballRb.velocity = new Vector2(xVelocity, yVelocity) * initialVelocity;
  }

  private void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.CompareTag("Paddle"))
    {
      ballRb.velocity *= velocityMultiplier;
    }
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Goal1")
    {
      GameManager.Instance.Paddle2Scored();
      GameManager.Instance.Restart();
      Launch();
    }
    else
    {
      GameManager.Instance.Paddle1Scored();
      GameManager.Instance.Restart();
      Launch();
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
