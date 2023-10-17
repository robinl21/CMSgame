using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner: MonoBehaviour
{
    public float speedUpFreq = 0.1f;
    public GameObject speedUpPrefab;
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
            timer = 0.0f;
        }
    }
    private void Spawn(int itemType) {
        /*GameObject rightWall = GameObject.Find("Vertical Boundary (1)");
        GameObject bottomWall = GameObject.Find("Wall (1)");
        GameObject upperWall = GameObject.Find("Wall");*/
        Debug.Log(rightWall.transform.position.x);
        bottomy = bottomWall.transform.position.y;
        uppery = upperWall.transform.position.y;
        float xcor = rightWall.transform.position.x;
        float ycor = Random.Range(bottomy, uppery);
        Instantiate(speedUpPrefab, new Vector3(xcor, ycor, 0), Quaternion.identity);
    }

}
