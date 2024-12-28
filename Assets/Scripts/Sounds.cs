using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip bronzeClip;    
    public AudioClip silverClip;    
    public AudioClip goldClip; 
    public GameManager gdev;     

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bronze"))
        {
                audioSource.PlayOneShot(bronzeClip);
                gdev.AddScore(1);
        }
        else if (other.CompareTag("Silver"))
        {
                audioSource.PlayOneShot(silverClip);
                gdev.AddScore(2);
        }
        else if (other.CompareTag("Gold"))
        {
                audioSource.PlayOneShot(goldClip);
                gdev.AddScore(3);
        }
    }
}
