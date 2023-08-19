using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_brick_breaker : MonoBehaviour
{
    public Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();

        rb.AddForce(Vector2.up * 500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
