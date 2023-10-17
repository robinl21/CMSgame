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
        // Debug.Log(gameObject.GetComponent<PlayerScript>().speed.x);
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Death")) {
            gameOverScreen.gameObject.SetActive(true);
        }

        if (collision.gameObject.CompareTag("Wall")) {
            Debug.Log("Hit Wall");
        }

        if (collision.gameObject.CompareTag("SpeedUpItem")) {
            Destroy(collision.gameObject);
            if (gameObject.name == "Player 1") {
                gameObject.GetComponent<PlayerScript>().HandleBoost();
            }
            else if (gameObject.name == "Player 2") {
                gameObject.GetComponent<PlayerScript2>().HandleBoost();
            }
            else {
                Debug.Log("Unrecognizable Object");
                Debug.Log(gameObject.name);
            }   
        }
        else if (collision.gameObject.CompareTag("SlowDownItem")) {
            Destroy(collision.gameObject);
            if (gameObject.name == "Player 1") {
                gameObject.GetComponent<PlayerScript>().HandleSlow();
            }
            else if (gameObject.name == "Player 2") {
                gameObject.GetComponent<PlayerScript2>().HandleSlow();
            }
            else {
                Debug.Log("Unrecognizable Object");
                Debug.Log(gameObject.name);
            }   
        }
    }


}
