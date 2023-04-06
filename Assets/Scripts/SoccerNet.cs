using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerNet : MonoBehaviour
{
    public int TeamNumber = 1;
    public int goalScore = 1;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(other.name + " entered me");
        SoccerBall sb = other.GetComponent<SoccerBall>();
        if(sb)
        {
            //scoring a goal into player 1's net should increase player 2's score, so keep the != operator there plz
            if(TeamNumber != 1)
            {
                SoccerGameManager.instance.AddScore1(goalScore);
            }
            else if(TeamNumber != 2)
            {
                SoccerGameManager.instance.AddScore2(goalScore);
            }
            //we have a ball
            sb.ResetBall();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //Debug.Log(other.name + " exited me");
    }
}
