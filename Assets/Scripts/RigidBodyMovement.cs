using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    public bool isPlayer1 = true;

    public float moveSpeed = 10;
    public float rotationSpeed = 90;
    public Vector3 moveDirection = Vector3.zero;

    public Vector2 input = Vector2.zero;

    private Transform transf; 

    bool upKey;
    bool downKey;
    bool leftKey;
    bool rightKey;
    bool strafeLeft;
    bool strafeRight;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
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
        if (strafeRight)
        {
            MoveRight(1);
        }
        if (strafeLeft)
        {
            MoveRight(-1);
        }
    }

    void GetInput()
    {
       if(isPlayer1)
       {
            GetInputPlayer1();
       }
       else
       {
            GetInputPlayer2();
       }
    }

    void GetInputPlayer1()
    {
        upKey = Input.GetKey(KeyCode.W);
        downKey = Input.GetKey(KeyCode.S);
        leftKey = Input.GetKey(KeyCode.A);
        rightKey = Input.GetKey(KeyCode.D);
        strafeLeft = Input.GetKey(KeyCode.Q);
        strafeRight = Input.GetKey(KeyCode.E);
    }

    void GetInputPlayer2()
    {
        upKey = Input.GetKey(KeyCode.I);
        downKey = Input.GetKey(KeyCode.K);
        leftKey = Input.GetKey(KeyCode.J);
        rightKey = Input.GetKey(KeyCode.L);
        strafeLeft = Input.GetKey(KeyCode.U);
        strafeRight = Input.GetKey(KeyCode.O);
    }

    //to move forwards and backwards
    void MovePlayer(float value)
    {
        rb.velocity = gameObject.transform.forward * moveSpeed * value;
    }

    void MoveRight(float value)
    {
        rb.velocity = gameObject.transform.right * moveSpeed * value;
    }

    void RotatePlayer(float value)
    {
        gameObject.transform.Rotate(value * rotationSpeed * Time.fixedDeltaTime * Vector3.up);
    }
}
