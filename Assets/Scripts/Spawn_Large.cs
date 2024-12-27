using System.Collections;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; 
    public float spawnDelay = 1.0f;  
    public float minX = -5f;         
    public float maxX = 5f;          
    public float minY = -5f;         
    public float maxY = 5f;          
    public float spawnZ = 45f;        

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true) // Infinite loop; modify as needed
        {
            SpawnObject();
            yield return new WaitForSeconds(spawnDelay);
        }
    }

    private void SpawnObject()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(randomX, randomY, spawnZ);
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}