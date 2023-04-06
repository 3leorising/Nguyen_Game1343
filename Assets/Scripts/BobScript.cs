using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour
{
    Vector3 startingPosition;
    public float bobHeight = 3;
    bool isGoingUp = true;

    // Start is called before the first frame update
    void Start()
    {
        
        startingPosition = gameObject.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        //GET 2/14/23 wiith assistance
        Vector3 objectPosition = gameObject.transform.position;

        //PROCESS
        //updating the position of the object
        if(isGoingUp)
        {
            objectPosition.y += bobHeight * Time.deltaTime;
        }
        else 
        {
            objectPosition.y -= bobHeight * Time.deltaTime;
        }

        //checking if the capsule has reached the highest/lowest points
        if(objectPosition.y >= bobHeight + startingPosition.y)
        {
            isGoingUp = false;
            objectPosition.y = bobHeight + startingPosition.y;
        }

        if(objectPosition.y <= startingPosition.y)
        {
            isGoingUp = true;
            objectPosition.y = startingPosition.y;
        }

        //SET
        gameObject.transform.position = objectPosition;
    }
}
