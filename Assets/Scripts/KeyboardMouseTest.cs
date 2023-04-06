using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMouseTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        //Part 1 Keyboard Mouse Test
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spacebar pressed");
        }
        
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Down");
        }
    }
}
