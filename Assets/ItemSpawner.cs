using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner: MonoBehaviour
{
    public float speedUpFreq = 0.1f;
    private float timer = 0.0f;

    void Start() {

    }

    void Update() {
        timer += Time.deltaTime;

        if (timer > 1f) {
            if (Random.value < speedUpFreq) {
                Spawn(0);
            }
            timer = 0.0f;
        }
    }
    private void Spawn(int itemType) {

    }

}

