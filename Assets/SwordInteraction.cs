using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordInteraction : MonoBehaviour
{
    public GameObject destroyEffect; // Assign the particle prefab in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object is a cube
        if (other.gameObject.CompareTag("Cube"))
        {
            // Spawn the particle effect at the cube's position
            Instantiate(destroyEffect, other.transform.position, Quaternion.identity);

            // Destroy the cube
            Destroy(other.gameObject);
            Debug.Log("Cube destroyed with particle effect!");
        }
    }
}