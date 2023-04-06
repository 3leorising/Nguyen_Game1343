using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SoccerGameManager : MonoBehaviour
{
    public static SoccerGameManager instance;
    public TextMeshProUGUI ScoreField1;
    public TextMeshProUGUI ScoreField2;

    int gameScore1 = 0;
    int gameScore2 = 0;

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
        gameScore1 = 0;
        gameScore2 = 0;
    }

    void Update()
    {
        ScoreField1.text = gameScore1.ToString();
        ScoreField2.text = gameScore2.ToString();
    }
    public void AddScore1(int score)
    {
        gameScore1 += score;
    }
    public void AddScore2(int score)
    {
        gameScore2 += score;
    }
}
