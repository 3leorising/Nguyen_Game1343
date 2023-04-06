using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    Vector3 startingPosition;
    Quaternion startingRotation;
    Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        startingPosition = gameObject.transform.position;
        startingRotation = gameObject.transform.rotation;
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetBall()
    {
        gameObject.transform.position = startingPosition;
        gameObject.transform.rotation = startingRotation;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
