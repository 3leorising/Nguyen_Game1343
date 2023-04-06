using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlinkoManager : MonoBehaviour
{
    public static PlinkoManager instance;
    public TextMeshProUGUI ScoreField;
    public TextMeshProUGUI DiskField;

    int gameScore = 0;
    int disksSpawned = 0;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
    }

    private void Start()
    {
        gameScore = 0;
        disksSpawned = 0;
    }

    void Update()
    {
        ScoreField.text = gameScore.ToString();
        DiskField.text = disksSpawned.ToString();
    }

    public void DisksSpawned()
    {
        disksSpawned++;
    }

    public void AddScore(int score)
    {
        gameScore += score;
    }
}
