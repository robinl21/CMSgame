using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
/// <summary>
/// Player controller and behavior
/// </summary>
public class PlayerScript : MonoBehaviour
{
  /// <summary>
  /// 1 - The speed of the ship
  /// </summary>

  public Vector2 speed;
  public GameObject otherPlayer;

  public float baseSpeed = 12;
 
  // 2 - Store the movement
  private Vector2 movement;

  private float speedMultiplier = 1.5f;
  private float boostTimer = -100.0f;
  private float boostLength = 3.0f;
  private float slowTimer = -100.0f;
  private float slowLength = 3.0f;

  void Start() {
    this.speed = GlobalSpeedScript.Instance.playerSpeed;
  }
  void Update()
  {
    //Debug.Log(GlobalSpeedScript.Instance.camVelocity);
    // 3 - Retrieve axis information
    float inputX = Input.GetAxis("Horizontal1");
    float inputY = Input.GetAxis("Vertical1");
 
    // 4 - Movement per direction
    movement = new Vector2(
      speed.x * inputX,
      speed.y * inputY);

 // Handles boost: Updates the boost timer, and resets player speed when it reaches 0
    if (boostTimer > -100.0f) {
      boostTimer -= Time.deltaTime;
      if (boostTimer <= 0.0f) {
          boostTimer = -100.0f;
          speed.x /= speedMultiplier;
          speed.y /= speedMultiplier;
      }
    }
    if (slowTimer > -100.0f) {
      slowTimer -= Time.deltaTime;
      if (slowTimer <= 0.0f) {
          slowTimer = -100.0f;
          otherPlayer.GetComponent<PlayerScript2>().speed.x *= speedMultiplier;
          otherPlayer.GetComponent<PlayerScript2>().speed.y *= speedMultiplier;
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

  public void HandleSlow()
  {
    if (slowTimer > -100.0f) {
      slowTimer = slowLength;
    }
    else {
      otherPlayer.GetComponent<PlayerScript2>().speed.x /= speedMultiplier;
      otherPlayer.GetComponent<PlayerScript2>().speed.y /= speedMultiplier;
      slowTimer = slowLength;
    }
  }
}