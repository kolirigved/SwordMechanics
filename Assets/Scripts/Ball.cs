using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] private Transform pieces;
    [SerializeField] private Transform sparks;

    public GameObject logic;
    public Logic logicScript;

    public float speedMax = 5.0f;
    public float speedMin = 1.0f;

    public float speed;
    public bool alive = true;

    public Vector3 movementDir = new Vector3(0, 0, -1);

    void Start()
    {
        GameObject logic = GameObject.FindWithTag("Logic");

        if (logic != null)
        {
            logicScript = logic.GetComponent<Logic>();
        }

        speed = Random.Range(speedMin, speedMax);
        Invoke("DestroyObject", 5f);


    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movementDir.normalized * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(pieces, transform.position, transform.rotation);
            Instantiate(sparks, transform.position, transform.rotation);
            logicScript.addScore();
            Destroy(gameObject);
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }

    
}
