using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public int damageAmount = 5;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();

            if (player.playerCanMove)
            {

                // apply damage to the player
                player.ApplyDamage(damageAmount);

            }
        }
    }
}
