using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{

    private GameObject player;

    public float attackDistance = 5f;

    public float timer = 4f;
    public int waitingTime = 3;

    public GameObject projectile;

    // Use this for initialization
    void Start()
    {
        player = GameObject.Find("Sparty");
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector2.Distance(transform.position, player.transform.position) < attackDistance)
        {
            Debug.Log("Player in attacking range");

            timer += Time.deltaTime;
            if (timer > waitingTime)
            {
                Instantiate(projectile, transform.position, transform.rotation);
                timer = 0;
            }

        }
    }
}