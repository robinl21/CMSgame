using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public Canvas gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Death")) {
            gameOverScreen.gameObject.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Wall")) {
            Debug.Log("Hit Wall");
        }


    }


}
