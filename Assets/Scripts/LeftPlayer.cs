using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlayer : MonoBehaviour
{
    public Listener listener;
    public Transform cube;

    public float[] handpos2 = new float[3];

    void Update()
    {

        handpos2 = listener.LeftHandData;
        if(handpos2[0] == 0 && handpos2[1] == 0 && handpos2[2] == 0){
            return;
        }
        cube.localPosition = new Vector3(10.0f * (handpos2[0]-0.5f), -10.0f * (handpos2[1]-0.5f), 0);
        cube.rotation = Quaternion.Euler(0, 0, 90+handpos2[2]); 
    }


}
