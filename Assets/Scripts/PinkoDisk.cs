using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkoDisk : MonoBehaviour
{
    public float lifespan = 50f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
