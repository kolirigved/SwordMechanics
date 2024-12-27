using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordEffects : MonoBehaviour
{

    public AudioSource bang;
    public Logic logic;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {   
        bang.Play();
    }
}
