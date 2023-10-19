using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBoundaryMovement : MonoBehaviour
{

    void Start()
    {

        this.GetComponent<Rigidbody2D>().velocity = GlobalSpeedScript.Instance.camVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity =  GlobalSpeedScript.Instance.camVelocity;
    }
}
