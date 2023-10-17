using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Speed : MonoBehaviour {
 
    public float speed = 15.0f;
    private float accelTimer;  

    void Start () {
        accelTimer = 0;
    }
   
    void Update () {
        accelTimer += Time.deltaTime;
        if (accelTimer >= 0.1f) {
            accelTimer = 0;
            speed *= 1.1f;
        }
        transform.position += transform.right * speed * Time.deltaTime;
   
    }
}