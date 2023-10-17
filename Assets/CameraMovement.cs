using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour

{
    public Vector2 camVelocity = Vector2.right;

    private float accelTimer = 0;  
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = camVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        accelTimer += Time.deltaTime;
        if (accelTimer >= 0.5f) {
            accelTimer = 0;
            this.GetComponent<Rigidbody2D>().velocity *= 1.005f;
            camVelocity = this.GetComponent<Rigidbody2D>().velocity;
        }
        // this.transform.position();
    }
}
