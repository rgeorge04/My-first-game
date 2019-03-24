using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redplat : MonoBehaviour
{
    float flyForce = 12f;
    void OnCollisionEnter2D(Collision2D redplat)
    {
        Rigidbody2D rb = redplat.collider.GetComponent<Rigidbody2D>();
        if (redplat.relativeVelocity.y <= 0f)
        {
            Vector2 velocity = rb.velocity;
            velocity.y = flyForce;
            rb.velocity = velocity;

        }
    }
}
