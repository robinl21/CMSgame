using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public Canvas gameOverScreen;
    private float speedMultiplier = 2;
    private float boostTimer = -100.0f;
    private float boostLength = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(gameObject.GetComponent<PlayerScript>().speed.x);
        // Handles boost: Updates the boost timer, and resets player speed when it reaches 0
        if (boostTimer > -100.0f) {
            boostTimer -= Time.deltaTime;
            if (boostTimer <= 0.0f) {
                boostTimer = -100.0f;
                gameObject.GetComponent<PlayerScript>().speed.x = gameObject.GetComponent<PlayerScript>().baseSpeed;
                gameObject.GetComponent<PlayerScript>().speed.y = gameObject.GetComponent<PlayerScript>().baseSpeed / 1.5f;
            }
        }
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
            if (boostTimer > -100.0f) {
                boostTimer = boostLength;
            }
            else {
                gameObject.GetComponent<PlayerScript>().speed.x *= speedMultiplier;
                gameObject.GetComponent<PlayerScript>().speed.y *= speedMultiplier;
                Debug.Log(gameObject.GetComponent<PlayerScript>().speed.x);
                boostTimer = boostLength;
            }
            
        }
    }


}
