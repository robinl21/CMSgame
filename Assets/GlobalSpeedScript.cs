using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSpeedScript : MonoBehaviour
{
    public static GlobalSpeedScript Instance; // static instance of this class

    // Start is called before the first frame update
    public Vector2 camVelocity = Vector2.right;

    public Vector2 playerSpeed = Vector2.right;

    private void Awake(){
        Instance = this;

    }

    // public void Update() {

    // }
}
