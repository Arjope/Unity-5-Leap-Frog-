using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2ScoreKeep : MonoBehaviour
{
    private int p2Score = 0;

    public void IncreaseScore()
    {
        p2Score += 1;
        Debug.Log("Player 2 Score: " + p2Score);
    }
}