using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBoundaryMovement : MonoBehaviour
{
    public GameObject cam; // put in through hierarchy
    private CameraMovement move_script;

    
    void Start()
    {
        move_script = cam.GetComponent<CameraMovement>();
        this.GetComponent<Rigidbody2D>().velocity = this.move_script.camVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // this.GetComponent<Rigidbody2D>().velocity = this.cam_script.camVelocity;
    }
}
