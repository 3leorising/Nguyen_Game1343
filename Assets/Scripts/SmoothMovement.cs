using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public float moveSpeed = 10;
    public float rotationSpeed = 90;
    public Vector3 moveDirection = Vector3.zero;

    public Vector2 input = Vector2.zero;

    private Transform transf; 


    bool upKey;
    bool downKey;
    bool leftKey ;
    bool rightKey ;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

         if(upKey)
        {
            MovePlayer(1);
        }

        if(downKey)
        {
            MovePlayer(-1);
        }

        if(leftKey)
        {
            RotatePlayer(-1);
        }

        if(rightKey)
        {
            RotatePlayer(1);
        }
    }

    void GetInput()
    {
        upKey = Input.GetKey(KeyCode.W);
        downKey = Input.GetKey(KeyCode.S);
        leftKey = Input.GetKey(KeyCode.A);
        rightKey = Input.GetKey(KeyCode.D);
    }

    //to move forwards and backwards
    void MovePlayer(float value)
    {
        //GET
        Vector3 location = gameObject.transform.position;

        //PROCESS
        location += value * moveSpeed * Time.deltaTime * gameObject.transform.forward;
        
        //SET
        gameObject.transform.position = location;
    }

    void RotatePlayer(float value)
    {
        gameObject.transform.Rotate(value * rotationSpeed * Time.deltaTime * Vector3.up);
    }
}
