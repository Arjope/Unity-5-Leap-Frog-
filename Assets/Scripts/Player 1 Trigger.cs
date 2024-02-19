using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Trigger : MonoBehaviour
{
    // Reference to Player 2's score script
    public P2ScoreKeep player2ScoreScript;

    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider belongs to Player 2
        if (other.gameObject.CompareTag("Player2"))
        {
            // Increase Player 2's score using the referenced score script
            player2ScoreScript.IncreaseScore();
        }
    }
}
