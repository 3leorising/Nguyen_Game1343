using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButtons : MonoBehaviour
{
    public string MainMenu = "MainMenu";
    public string Plinko = "Plinko";
    public string Soccerfield = "Soccerfield";
    public string Combat = "Combat";

    //needa figure out how to move back to the main menu from plinko screen
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(MainMenu);
    }

    public void LoadPlinko()
    {
        SceneManager.LoadScene(Plinko);
    }

    public void LoadSoccer()
    {
        SceneManager.LoadScene(Soccerfield);
    }

    public void LoadCombat()
    {
        SceneManager.LoadScene(Combat);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
