using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Speed : MonoBehaviour {
 
    public float speed = 15.0f;  
   
    void Update () {
 
        transform.position += transform.right * speed * Time.deltaTime;
   
    }
}