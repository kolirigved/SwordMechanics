using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bronze_Block : MonoBehaviour
{
    public float velocityZ = 5f;
    public Rigidbody rb;

    void Update()
    {
        rb.velocity = new Vector3(0, 0, -velocityZ); 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Sword")||other.CompareTag("Finish"))
        {
            Destroy(gameObject); 
        }
    }
}
