using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class AppManager : MonoBehaviour
{

    public static AppManager instance; 

    int RedVisits = 0;
    int GreenVisits = 0;
    int BlueVisits = 0;
    
    public TextMeshProUGUI RedField;
    public TextMeshProUGUI GreenField;
    public TextMeshProUGUI BlueField;

    private void Awake()
    {
        // Destroy the object if there is another one. 
        // The other Object is the correct singleton... 
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject); 

        // Not all Singletons Persits from Scene to Scene
        // This one does to demostrate it

    }

    void Start()
    {
        UpdateBoard();
    }

    public void UpdateBoard()
    {
        RedField.text   =  RedVisits.ToString();
        BlueField.text  =  BlueVisits.ToString();
        GreenField.text =  GreenVisits.ToString();
    }

    public void RedVisit()
    {
        RedVisits++;
        UpdateBoard();
    }

    public void BlueVisit()
    {
        BlueVisits++;
        UpdateBoard();
    }

    public void GreenVisit()
    {
        GreenVisits++;
        UpdateBoard();
    }

}
