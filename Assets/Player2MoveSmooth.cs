using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript2 : MonoBehaviour
{
  /// <summary>
  /// 1 - The speed of the ship
  /// </summary>
  public Vector2 speed = new Vector2(12, 8);
 
  // 2 - Store the movement
  private Vector2 movement;
  public float baseSpeed = 12;

  private float speedMultiplier = 2.5f;
  private float boostTimer = -100.0f;
  private float boostLength = 3.0f;
 
  void Update()
  {
    // 3 - Retrieve axis information
    float inputX = Input.GetAxis("Horizontal2");
    float inputY = Input.GetAxis("Vertical2");
 
    // 4 - Movement per direction
    movement = new Vector2(
      speed.x * inputX,
      speed.y * inputY);

    if (boostTimer > -100.0f) {
      boostTimer -= Time.deltaTime;
      if (boostTimer <= 0.0f) {
          boostTimer = -100.0f;
          speed.x = baseSpeed;
          speed.y = baseSpeed / 1.5f;
      }
    }
  }
 
  void FixedUpdate()
  {
    // 5 - Move the game object
    GetComponent<Rigidbody2D>().velocity = movement;
  }

  public void HandleBoost()
  {
    if (boostTimer > -100.0f) {
      boostTimer = boostLength;
    }
    else {
      speed.x *= speedMultiplier;
      speed.y *= speedMultiplier;
      Debug.Log(speed.x);
      boostTimer = boostLength;
    }
  }
}