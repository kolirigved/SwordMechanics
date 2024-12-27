using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Ballz;
    public GameObject vfx;
    public AudioSource boom;

    private Transform[] Empties;

    public float lowTime = 1f;
    public float highTime = 2f;

    private void Start()
    {
        Empties = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            Empties[i] = transform.GetChild(i);
        }

        StartCoroutine(SpawnObject());
    }

    private System.Collections.IEnumerator SpawnObject()
    {
        while (true)
        {
            float randomInterval = Random.Range(lowTime, highTime);
            yield return new WaitForSeconds(randomInterval);

            Transform randomSpawnPoint = Empties[Random.Range(0, Empties.Length)];

            GameObject ball = Instantiate(Ballz, randomSpawnPoint.position, randomSpawnPoint.rotation);
            Instantiate(vfx, randomSpawnPoint.position, randomSpawnPoint.rotation);

            ball.tag = "lol";
            boom.Play();

        }
    }
}
