using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCube : MonoBehaviour
{
    public GameObject cube;
    public float spawnRate=2;
    public float Timer= 0;
    public float boxesAppeared= 0;
    public float heightOffsetX= 0.5f, heightOffsetY= 0.5f, offsetZ= 2;
    // Start is called before the first frame update
    void Start()
    {
        spawn_Cube();
        boxesAppeared++;
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer < spawnRate){
            Timer += Time.deltaTime;

        }else{
            spawn_Cube();
            boxesAppeared++;
            Timer =0;
        }
    }
    void spawn_Cube(){
        float lowestPointX = transform.position.x - heightOffsetX;
        float highestPointX = transform.position.x + heightOffsetX;
        float lowestPointY = transform.position.y - heightOffsetY;
        float highestPointY = transform.position.y + heightOffsetY;

        Instantiate(cube, new Vector3(Random.Range(lowestPointX, highestPointX), Random.Range(lowestPointY, highestPointY), Random.Range(transform.position.z - offsetZ , transform.position.z)), transform.rotation);
    }
}
