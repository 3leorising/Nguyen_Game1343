using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CombatManager : MonoBehaviour
{
    public static CombatManager instance;
    public TextMeshProUGUI DeathsField;

    int deaths = 0;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    void Start()
    {
        deaths = 0;
    }

    void Update()
    {
        DeathsField.text = deaths.ToString();
    }

    public void AddDeath(int point)
    {
        deaths += point;
    }
}
