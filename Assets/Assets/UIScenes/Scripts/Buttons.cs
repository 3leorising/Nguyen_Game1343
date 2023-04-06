using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    // Level Name Variables 
    string MainMenu_Scene = "MainMenu";
    string Red_Scene    = "Room_Red";
    string Green_Scene  = "Room_Green";
    string Blue_Scene   = "Room_Blue";
   

    public void StartGame()
    {
        Debug.Log("Start Game");
        SceneManager.LoadScene(Red_Scene);
    }

    public void EndGame()
    {
        Debug.Log("End Game");
        SceneManager.LoadScene(MainMenu_Scene);
    }

    public void RedButton()
    {
        Debug.Log("Red Button");
        SceneManager.LoadScene(Red_Scene); 
       
    }

    public void GreenButton()
    {
        Debug.Log("Green Button");
        SceneManager.LoadScene(Green_Scene);
    }

    public void BlueButton()
    {
        Debug.Log("Blue Button");
        SceneManager.LoadScene(Blue_Scene);
    }

   
}
