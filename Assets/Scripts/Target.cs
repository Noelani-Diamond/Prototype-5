using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    Rigidbody targetRb;
    float minSpeed = 12;
    float maxSpeed = 20;
    float maxTorque = 10;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();

        targetRb.AddTorque(Random.Range(-maxTorque, maxTorque), Random.Range(-maxSpeed, maxSpeed), Random.Range(-maxTorque, maxTorque), ForceMode.Impulse);
        targetRb.AddForce(Vector2.up * Random.Range(minSpeed, maxSpeed), ForceMode.Impulse);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
