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
  public Vector2 speed;
  public GameObject otherPlayer;
 
  // 2 - Store the movement
  private Vector2 movement;
  public float baseSpeed = 12;

  private float speedMultiplier = 1.5f;
  private float boostTimer = -100.0f;
  private float boostLength = 3.0f;
  private float slowTimer = -100.0f;
  private float slowLength = 3.0f;
  private float slowSelfTimer = -100.0f;
 

  void Start() {
    this.speed = GlobalSpeedScript.Instance.playerSpeed;
  }
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
          speed.x /= speedMultiplier;
          speed.y /= speedMultiplier;
      }
    }
    if (slowTimer > -100.0f) {
      slowTimer -= Time.deltaTime;
      if (slowTimer <= 0.0f) {
          slowTimer = -100.0f;
          otherPlayer.GetComponent<PlayerScript>().speed.x *= speedMultiplier;
          otherPlayer.GetComponent<PlayerScript>().speed.y *= speedMultiplier;
      }
    }
    if (slowSelfTimer > -100.0f) {
      slowSelfTimer -= Time.deltaTime;
      if (slowSelfTimer <= 0.0f) {
          slowSelfTimer = -100.0f;
          speed.x *= speedMultiplier;
          speed.y *= speedMultiplier;
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
      otherPlayer.GetComponent<PlayerScript>().speed.x /= speedMultiplier;
      otherPlayer.GetComponent<PlayerScript>().speed.y /= speedMultiplier;
      slowTimer = slowLength;
    }
  }

  public void HandleSlowSelf()
  {
    if (slowTimer > -100.0f) {
      slowSelfTimer = slowLength;
    }
    else {
      speed.x /= speedMultiplier;
      speed.y /= speedMultiplier;
      slowSelfTimer = slowLength;
    }
  }
}