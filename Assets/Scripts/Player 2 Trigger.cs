using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Trigger : MonoBehaviour
{
    // Reference to Player 1's score script
    public PlayerManager playerManager;

    void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider belongs to Player 1
        if (other.gameObject.CompareTag("Player1"))
        {
            // Increase Player 1's score using the referenced score script
            playerManager.ChangeScore(1, 1);
        }
    }
}
