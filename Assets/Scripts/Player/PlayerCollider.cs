﻿using UnityEngine;

/*
 * Provide the obstacles with a way of damaging the player.
 */
public class PlayerCollider : MonoBehaviour
{
    /*
     * A trigger callback to detect when the player's collider has entered the obstacle's. 
     * Then simply obtain the PlayerController reference can apply damage. 
     * In fact, damage is what makes you jump to another Scene
     */
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Obtain a reference to the Player's PlayerController
        PlayerController playerController =
          other.gameObject.GetComponent<PlayerController>();

        // Register damage with player
        playerController.Damage();
    }
}
