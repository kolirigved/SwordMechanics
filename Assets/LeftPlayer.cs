using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayer : MonoBehaviour
{
    public Listener listener;
    public Transform cube;

    public float[] handpos1 = new float[3]; // x,y,rotation data of hand

    void Update()
    {
        handpos1 = listener.LeftHandData;

        if (handpos1[0] == 0 && handpos1[1] == 0 && handpos1[2] == 0)
        {
            return;
        }

        cube.position = new Vector3(10.0f * (handpos1[0]-0.5f), -10.0f * (handpos1[1]-0.5f), 0);
        cube.rotation = Quaternion.Euler(0, 0, handpos1[2]); // rotation around z axis
    }
}