using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public Vector3 SpinRate = Vector3.zero; 
    void Update ()
    {
        gameObject.transform.Rotate(SpinRate * Time.deltaTime); 
	}
}
