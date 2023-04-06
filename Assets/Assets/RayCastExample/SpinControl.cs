using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinControl : MonoBehaviour
{
    public Vector3 SpinRate = Vector3.zero; 
    
    void Update()
    {
        gameObject.transform.Rotate(SpinRate * Time.deltaTime);     
    }
}
