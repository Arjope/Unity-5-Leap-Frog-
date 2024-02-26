using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class P2ScoreKeep : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI p2ScoreText;
    [SerializeField] private int p2Score;
    [SerializeField] private TextMeshProUGUI p2WinsText;

    public void Start()
    {
        p2ScoreText.text = "Player 2 Score: " + 0;
    }

    public void IncreaseScore()
    {
        p2Score += 1;
        p2ScoreText.text = "Player 2 Score: " + p2Score.ToString();
        Debug.Log("Player 2 Score: " + p2Score);

        if (p2Score == 4)
        {
            p2WinsText.text = "Player 2 Wins!";
        }
    }
}