using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody Rb;
    private float minSpeed = 12;
    private float maxSpeed = 16;
    
    private float maxForce = 10;
    private float xRange = 4;
    private float yRange = 2;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody>();

        Rb.AddForce(RandomForce(), ForceMode.Impulse);
        Rb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse); //for rotation

        transform.position = newPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxForce, maxForce);
    }
    Vector3 newPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), -yRange);
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
