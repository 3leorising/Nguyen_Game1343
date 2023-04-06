using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    //part 2 Grid Movement
    int gridSize = 5;
    bool upKey, downKey, leftKey, rightKey;
    private Transform transf; 
    float upDirection, downDirection, leftDirection, rightDirection;
    
    // Start is called before the first frame update
    void Start()
    {
        transf = gameObject.transform;
        transf = gameObject.GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        //setting up the key inputs
        upKey = Input.GetKeyDown(KeyCode.I);
        downKey = Input.GetKeyDown(KeyCode.K);
        leftKey = Input.GetKeyDown(KeyCode.J);
        rightKey = Input.GetKeyDown(KeyCode.L);

        upDirection = 0f;
        downDirection = 180f;
        leftDirection = 270f;
        rightDirection = 90f;

        if(upKey)
        {
            transform.position += new Vector3 (0f, 0f, gridSize);
            transform.eulerAngles = new Vector3(0f, upDirection, 0f);
        }
        if(downKey)
        {
            transform.position += new Vector3 (0f, 0f, -gridSize);
            transform.eulerAngles = new Vector3(0f, downDirection, 0f);
        }
        if(leftKey)
        {
            transform.position += new Vector3 (-gridSize, 0f, 0f);
            transform.eulerAngles = new Vector3(0f, leftDirection, 0f);
        }
        if(rightKey)
        {
            transform.position += new Vector3 (gridSize, 0f, 0f);
            transform.eulerAngles = new Vector3(0f, rightDirection, 0f);
        }
    }

    //lecture 2/14/23. Whatever I originally did worked, but this is what i could remember from class. It isn't 100% all written down tho

    /*void Update()
    {
        getInput();
         //GET
        Vector3 position = gameObject.transform.position;

        //PROCESS
        position += MoveSpeed * gridSize;

        //SET
        gameObject.transform.position = position;
    }*/

    /*void getInput()
    {
        moveDirection = Vector3.zero;
        
        //UP
        if(Input.GetKeyDown(KeyCode.I))
        {
            moveDirection.x += 1;
        }
    }*/
    
}
