using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RightPlayer : MonoBehaviour
{
    public Listener listener;
    public Transform cube;

    public float[] handpos2 = new float[3]; // x,y,rotation data of hand

    void Update()
    {
        handpos2 = listener.RightHandData;

        if (handpos2[0] == 0 && handpos2[1] == 0 && handpos2[2] == 0)
        {
            return;
        }

        cube.position = new Vector3(10.0f * (handpos2[0] - 0.5f), -10.0f * (handpos2[1] - 0.5f), 0);
        cube.rotation = Quaternion.Euler(0, 0, handpos2[2]); // rotation around z axis
    }
}