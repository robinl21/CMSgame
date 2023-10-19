using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour

{

    // private float accelTimer = 0;  
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = GlobalSpeedScript.Instance.camVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = GlobalSpeedScript.Instance.camVelocity;
        // accelTimer += Time.deltaTime;
        // if (accelTimer >= 0.5f) {
        //     accelTimer = 0;
        //     this.GetComponent<Rigidbody2D>().velocity *= 1.005f;
        //     camVelocity = this.GetComponent<Rigidbody2D>().velocity;
        // }
        // this.transform.position();
    }
}
