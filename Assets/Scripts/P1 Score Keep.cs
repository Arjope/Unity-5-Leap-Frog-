using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1ScoreKeep : MonoBehaviour
{
    private int p1Score = 0;

    public void IncreaseScore()
    {
        p1Score += 1;
        Debug.Log("Player 1 Score: " + p1Score);
    }
}