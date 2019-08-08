using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{


    private Rigidbody2D rb;

    public int damageAmount = 5;

    public float speed = 5f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(-speed, 0f);

    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.tag == "Player"))
        {        
        
            CharacterController2D player = collision.gameObject.GetComponent<CharacterController2D>();

            if (player.playerCanMove)
            {

                // apply damage to the player
                player.ApplyDamage(damageAmount);

                Destroy(gameObject);
            }
        }
    }
}
