using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Part II - Moving Cylinders. The code is referencing ppt3_Transform.pptx
    public Vector3 moveDirection; //#2
    private Transform transf; //#3

    // Start is called before the first frame update
    void Start()
    {
        transf = gameObject.transform;
        Debug.Log(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        //this works, but I should make GET PROCESS SET a habit
        //transf.Translate(moveDirection * Time.deltaTime); 
        
        //class lecture 2/14/23
        //GET
        Vector3 position = transf.position;

        //PROCESS
        position += moveDirection * Time.deltaTime;

        //SET
        transf.position = position;
        
    }
}
