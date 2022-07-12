using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  float moveSpeed = 10f;
  float direction;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    direction = Input.GetAxis("Vertical");
    float movement = direction * moveSpeed * Time.deltaTime;
    transform.Translate(0, movement, 0);
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    // arriba +
    // abajo -
  }
}
