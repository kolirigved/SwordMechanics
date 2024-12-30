using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed

    private void Update()
    {
        // Move the cube in the negative Z direction
        transform.position += Vector3.back * speed * Time.deltaTime;

        // Destroy the cube if it moves out of bounds
        if (transform.position.z < -10f) // Adjust the boundary based on your scene size
        {
            Destroy(gameObject);
            Debug.Log("Cube destroyed after moving past the sword.");
        }
    }
}
