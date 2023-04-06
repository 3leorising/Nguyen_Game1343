using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinScript : MonoBehaviour
{
    // Part III Spinning Boxes
    public Vector3 spinSpeed; 
    private Transform transf; 

    // Start is called before the first frame update
    void Start()
    {
        transf = gameObject.transform; //#4
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(spinSpeed * Time.deltaTime); 
        //this was ok to do, but can be improved using the transf reference i created in Start()
        transf.Rotate(spinSpeed * Time.deltaTime);
    }
}
