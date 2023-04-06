using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitApplication : MonoBehaviour
{


     public static string webplayerQuitURL = "http://google.com";

    public void Quit()
    {
        Debug.Log("Quit Applicaiton"); 

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif

#if UNITY_WEBPLAYER
        Application.OpenURL(webplayerQuitURL);
#endif

        Application.Quit();

    }

}
