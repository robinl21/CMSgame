using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 upPos = Vector2.up;

    public Vector2 rightPos = Vector2.right;

    public Vector2 leftPos = Vector2.left;
    public Vector2 downPos = Vector2.down;
    public KeyCode upKey = KeyCode.UpArrow;
    public KeyCode leftKey = KeyCode.LeftArrow;
    public KeyCode downKey = KeyCode.DownArrow;
    public KeyCode rightKey = KeyCode.RightArrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(this.upKey)) {
            this.GetComponent<Rigidbody2D>().position += upPos;
        }
        if (Input.GetKeyDown(this.leftKey)) {
            this.GetComponent<Rigidbody2D>().position += leftPos;
        }
        if (Input.GetKeyDown(this.rightKey)) {
            this.GetComponent<Rigidbody2D>().position +=  rightPos;
        }
        if (Input.GetKeyDown(this.downKey)) {
            this.GetComponent<Rigidbody2D>().position += downPos;
        }
    }
}
