using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{

    private Rigidbody2D rb;
    private GameObject player;
    private CharacterController2D controller;

    public float speed = 10f;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Sparty");
        controller = player.GetComponent<CharacterController2D>();

        if (controller.facingRight == true)
        {
            rb.velocity = new Vector2(speed, 0f);

        }
        else
        {

            rb.velocity = new Vector2(-speed, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }

}
