using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{

    public float moveSpeed =-1;
    public float deadZone = -11;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +(Vector3.forward *Random.Range(moveSpeed-1, moveSpeed))* Time.deltaTime;
        if(transform.position.z < deadZone){
            Debug.Log("Box Destroyed!");
            Destroy(gameObject);
        }
    }

}