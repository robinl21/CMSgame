using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner: MonoBehaviour
{
    public float speedUpFreq = 0.1f;
    public GameObject speedUpPrefab;
    public GameObject slowDownPrefab;
    public GameObject rightWall;
    public GameObject bottomWall;
    public GameObject upperWall;
    private float timer = 0.0f;
    public float bottomy;
    public float uppery;

    void Start() {
        
    }

    void Update() {
        timer += Time.deltaTime;

        if (timer > 1.0f) {
            if (Random.value < speedUpFreq) {
                Spawn(0);
            }
            if (Random.value < speedUpFreq) {
                Spawn(1);
            }
            timer = 0.0f;
        }
    }
    private void Spawn(int itemType) {
        bottomy = bottomWall.transform.position.y;
        uppery = upperWall.transform.position.y;
        float xcor = rightWall.transform.position.x;
        float ycor = Random.Range(bottomy, uppery);
        if (itemType == 0) {
            Instantiate(speedUpPrefab, new Vector3(xcor, ycor, 0), Quaternion.identity);
        }
        else if (itemType == 1) {
            Instantiate(slowDownPrefab, new Vector3(xcor, ycor, 0), Quaternion.identity);
        }
    }

}

