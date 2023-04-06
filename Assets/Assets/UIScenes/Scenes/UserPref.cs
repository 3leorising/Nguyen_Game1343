using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class UserPref : MonoBehaviour {

    
    string userName;
    public InputField UserField;

	// Use this for initialization
	void Start () {
        userName = PlayerPrefs.GetString("UserName");
       
        if (userName == "")
        {
            userName = "User";
        }
            
        Debug.Log("userName: " + userName);

        UserField.text = userName; 

    }
	
	// Update is called once per frame
	public void SaveUserName () {

        PlayerPrefs.SetString("UserName", UserField.text);
        PlayerPrefs.Save(); 
	}
}
