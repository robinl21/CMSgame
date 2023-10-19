using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Speed : MonoBehaviour {
 

    
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = GlobalSpeedScript.Instance.camVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody2D>().velocity = GlobalSpeedScript.Instance.camVelocity;
    }
}