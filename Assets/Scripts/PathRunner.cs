using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathRunner : MonoBehaviour
{
    public GameObject targetA;
    public GameObject targetB;
    public float moveSpeed = 5;
    public float withinRange = .75f;
    public bool hasDynamicDirection = false;
    
    GameObject currentTarget;
    bool isMovingToA = true;

    Vector3 moveDirection = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        isMovingToA = true;
        currentTarget = targetA;
        UpdateMoveDirection();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasDynamicDirection)
        {
            UpdateMoveDirection();
        }

        //generic movement code that has been used the past few weeks
        Vector3 position = gameObject.transform.position;
        position += moveDirection * moveSpeed * Time.deltaTime;
        gameObject.transform.position = position;

        if (isCloseToTarget())
        {
            NextTarget();
            UpdateMoveDirection();
        }
    }

    //takes and calculates the distance between the gameObject and the other gameObject
    public float GetDistanceTo(GameObject Other)
    {
        Vector3 distance = Other.transform.position - gameObject.transform.position;
        return distance.magnitude;
    }

    //checks if the gameObject is within range from the target
    public bool isCloseToTarget()
    {
        if(GetDistanceTo(currentTarget) <= withinRange)
        {
            return true;
        }

        return false;
    }

//switches between targets
    void NextTarget()
    {
        if (isMovingToA)
        {
            currentTarget = targetB;
            isMovingToA = false;
        }
        else 
        {
            currentTarget = targetA;
            isMovingToA = true;
        }
    }

    //sets the movement direction vector to its new target
    void UpdateMoveDirection()
    {
        moveDirection = currentTarget.transform.position - gameObject.transform.position;
        moveDirection = moveDirection.normalized;

        gameObject.transform.forward = moveDirection;
    }

}
