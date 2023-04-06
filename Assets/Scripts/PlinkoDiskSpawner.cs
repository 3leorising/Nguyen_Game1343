using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoDiskSpawner : MonoBehaviour
{
    public GameObject plinkoDisk;
    public float lifespan = 5f;

    private void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //spawn a disk
            Instantiate(plinkoDisk, gameObject.transform.position, Quaternion.identity);
            PlinkoManager.instance.DisksSpawned();
        }
    }
}
