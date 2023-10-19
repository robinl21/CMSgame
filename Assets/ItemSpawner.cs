using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner: MonoBehaviour
{
    public float speedUpFreq = 0.3f;
    public float slowDownFreq = 0.2f;
    public float bananaFreq = 0.35f;
    public GameObject speedUpPrefab;
    public GameObject slowDownPrefab;
    public GameObject bananaPrefab;
    public GameObject rightWall;
    public GameObject leftWall;
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
            if (Random.value < slowDownFreq) {
                Spawn(1);
            }
            if (Random.value < bananaFreq) {
                Spawn(2);
            }
            timer = 0.0f;
        }
    }
    private void Spawn(int itemType) {
        bottomy = bottomWall.transform.position.y;
        uppery = upperWall.transform.position.y;
        float xcor = rightWall.transform.position.x;
        if (itemType != 2) {
            if (Random.value > 0.5) {
                xcor = (rightWall.transform.position.x + leftWall.transform.position.x) / 2;
            }
        }
        float ycor = Random.Range(bottomy, uppery);
        if (itemType == 0) {
            Instantiate(speedUpPrefab, new Vector3(xcor, ycor, 0), Quaternion.identity);
        }
        else if (itemType == 1) {
            Instantiate(slowDownPrefab, new Vector3(xcor, ycor, 0), Quaternion.identity);
        }
        else if (itemType == 2) {
            Instantiate(bananaPrefab, new Vector3(xcor, ycor, 0), Quaternion.identity);
        }
    }

}

