using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // Assign the cube prefab in the Inspector
    public float spawnInterval = 2f; // Time between spawns
    public float spawnRangeX = 10f; // Range for spawn positions on the X-axis
    public float spawnPositionZ = 30f; // Fixed Z position for spawning cubes

    private void Start()
    {
        InvokeRepeating(nameof(SpawnCube), 0f, spawnInterval);
    }

    private void SpawnCube()
    {
        // Generate a random X position for the cube
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX), // Random X position
            1f,                                     // Fixed Y position
            spawnPositionZ                          // Fixed Z position
        );

        // Instantiate the cube
        Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}
