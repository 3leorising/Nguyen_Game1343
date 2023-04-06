using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{
    //idk what this script is for. Its replacing the single line of code in InputPoller.cs
    //this script is supposed to be inside CombatManager GameObject

    //ok i figured out what this script was for. It was to demonstrate that sometimes singletons persist through scenes, and this script prevented destroying the singleotn's instance. That shouldnt happen in most scenarios
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

}
