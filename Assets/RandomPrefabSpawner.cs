using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPrefabSpawner : MonoBehaviour
{
    public GameObject[] prefabs; // Array of prefabs to spawn
    public Transform VerticalBoundary;
    public float spawnFrequency = 0.05f; // Probability of spawning each prefab
    private List<GameObject> spawnedPrefabs = new List<GameObject>();
    private float timer = 0f;

    void Start()
    {
        // Load prefabs from the "targets" folder and assign them to the prefabs array

    }

    void Update(){
        // Increment the timer each frame
        timer += Time.deltaTime;

        // Check if the timer has reached the desired interval
        if (timer > 1.0f)
        {
            Spawn(Random.Range(0, prefabs.Length));
            
            // Reset the timer after spawning
            timer = 0.0f;
        }
    }

private void Spawn(int prefabIndex)
{
    float lineStart = VerticalBoundary.position.y - VerticalBoundary.localScale.y / 2;
    float yRange = VerticalBoundary.localScale.y;
    Vector2 spawnLocation = new Vector2(VerticalBoundary.position.x, lineStart + Random.Range(0, yRange));

    // Create the new prefab instance
    GameObject spawnInstance = Instantiate(prefabs[prefabIndex]);
    spawnInstance.transform.position = spawnLocation;

}




}
