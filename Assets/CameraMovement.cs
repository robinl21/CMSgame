using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour

{
    public Vector2 camVelocity = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody2D>().velocity = camVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        // this.transform.position();

    }
}
