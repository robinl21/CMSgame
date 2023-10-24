using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSpeedScript : MonoBehaviour
{
    public static GlobalSpeedScript Instance; // static instance of this class

    // Start is called before the first frame update
    public Vector2 camVelocity = Vector2.right;

    public Vector2 playerSpeed = Vector2.right;

    private float accelFactor = 1.005f;
    private float accelTimer = 0;


    private void Awake(){
        Instance = this;

    }

    public void Update() {
        accelTimer += Time.deltaTime;
        if (accelTimer >= 0.5f) {
            accelTimer = 0;
            this.camVelocity *= accelFactor;
            // PlayerScript.Player1.speed.x *= accelFactor;
            // PlayerScript2.Player2.speed.x *= accelFactor;

            // PlayerScript.Player1.speed.y *= accelFactor;
            // PlayerScript2.Player2.speed.y *= accelFactor;
        }
    }
}
