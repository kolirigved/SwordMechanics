using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenBalls : MonoBehaviour
{
    void Start()
    {
        // Call the DestroyObject method after a delay of 2 seconds
        Invoke("DestroyObject", 2f);
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
}
