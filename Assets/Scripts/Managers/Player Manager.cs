using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour, IGameManager
{
    public ManagerStatus status { get; private set; }

    public int health { get; private set; }
    public int maxHealth { get; private set; }

    public int player1Score { get; private set; }
    public int player2Score { get; private set; }

    [SerializeField] private TextMeshProUGUI p1ScoreText;
    [SerializeField] private TextMeshProUGUI p2ScoreText;
    [SerializeField] private TextMeshProUGUI p1WinsText;
    [SerializeField] private TextMeshProUGUI p2WinsText;

    public void Startup()
    {
        Debug.Log("Player manager starting...");

        health = 50;
        maxHealth = 100;
        player1Score = 0;
        player2Score = 0;

        p1ScoreText.text = "Player 1 Score: " + 0;
        p2ScoreText.text = "Player 2 Score: " + 0;

        status = ManagerStatus.Started;
    }

    public void ChangeHealth(int value)
    {
        health += value;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health < 0)
        {
            health = 0;
        }

        Debug.Log($"Health: {health}/{maxHealth}");
    }

    public void ChangeScore(int player, int value)
    {
        if (player == 1)
        {
            player1Score += value;
            p1ScoreText.text = "Player 1 Score: " + player1Score.ToString();
            Debug.Log($"Player 1 Score: {player1Score}");

            if (player1Score == 4)
            {
                p1WinsText.text = "Player 1 Wins!";
            }
        }
        else if (player == 2)
        {
            player2Score += value;
            p2ScoreText.text = "Player 2 Score: " + player2Score.ToString();
            Debug.Log($"Player 2 Score: {player2Score}");

            if (player2Score == 4)
            {
                p2WinsText.text = "Player 2 Wins!";
            }
        }
    }
}
