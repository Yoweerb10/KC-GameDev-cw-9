using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform groundPos;
    public float speed;
    public float rad;
    public LayerMask groundLayer;

    Rigidbody2D RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyPatrol();
    }

    void EnemyPatrol()
    {
        RB.velocity = new Vector2(speed, 0f);

        bool isGrounded = Physics2D.OverlapCircle(groundPos.position, rad, groundLayer);

        if (isGrounded)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            speed *= -1;
        }
    }
}
