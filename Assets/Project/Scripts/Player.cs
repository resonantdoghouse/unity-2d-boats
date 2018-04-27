using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

  private BoxCollider2D boxCollider;

  private Vector3 moveDelta;

  public float boatSpeed;

  // Use this for initialization
  private void Start()
  {
    boxCollider = GetComponent<BoxCollider2D>();
  }

  // Update is called once per frame
  private void FixedUpdate()
  {
    float x = Input.GetAxisRaw("Horizontal");
    float y = Input.GetAxisRaw("Vertical");

    // Reset move delta
    moveDelta = new Vector3(x, y, 0);

    if (moveDelta.x > 0)
      transform.localScale = Vector3.one;
    else if (moveDelta.x < 0)
      transform.localScale = new Vector3(-1, 1, 1);

    // Move player
    transform.Translate(moveDelta * Time.deltaTime * boatSpeed);

    Debug.Log(x);
    Debug.Log(y);
  }
}
