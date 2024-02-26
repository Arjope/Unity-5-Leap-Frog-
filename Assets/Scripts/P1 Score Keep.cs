using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class P1ScoreKeep : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI p1ScoreText;
    [SerializeField] private int p1Score;
    [SerializeField] private TextMeshProUGUI p1WinsText;

    public void Start()
    {
        p1ScoreText.text = "Player 1 Score: " + 0;
    }

    public void IncreaseScore()
    {
        p1Score += 1;
        p1ScoreText.text = "Player 1 Score: " + p1Score.ToString();
        Debug.Log("Player 1 Score: " + p1Score);

        if (p1Score == 4)
        {
            p1WinsText.text = "Player 1 Wins!";
        }
    }
}