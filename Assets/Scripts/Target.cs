using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    Rigidbody targetRb;
    float minSpeed = 12;
    float maxSpeed = 20;
    float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxSpeed, maxSpeed), Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
        targetRb.AddForce(Vector2.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);
        transform.position = RandomSpawnPos();


    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    
    }

    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
