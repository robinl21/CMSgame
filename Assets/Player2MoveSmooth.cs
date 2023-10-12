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
 
  void Update()
  {
    // 3 - Retrieve axis information
    float inputX = Input.GetAxis("Horizontal2");
    float inputY = Input.GetAxis("Vertical2");
 
    // 4 - Movement per direction
    movement = new Vector2(
      speed.x * inputX,
      speed.y * inputY);
 
  }
 
  void FixedUpdate()
  {
    // 5 - Move the game object
    GetComponent<Rigidbody2D>().velocity = movement;
  }
}