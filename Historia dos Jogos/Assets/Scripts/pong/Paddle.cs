using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public bool isAI;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    public GameObject ball;
    public float topScreenEdge;
    public float bottomScreenEdge;

    private float movement;
    private AudioSource audio;

    
    private void Start()
    {
        startPosition = transform.position;
        audio = GetComponent<AudioSource> ();
    }
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
           
        }
        else if (isAI)
        {
            if (ball != null && ball.transform.position.x > 0)
            {
                float targetY = Mathf.MoveTowards(transform.position.y, ball.transform.position.y, speed * Time.deltaTime * 30);
                movement = Mathf.Clamp(targetY - transform.position.y, -3f, 3f);
                
            }
            else { movement = 0f; }
        }
    
               else
       {
              
                movement = Input.GetAxisRaw("Vertical2");
       }

        rb.velocity = new Vector2 (0, movement * speed);

    }

    public void Reset()
    {

        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            audio.Play();
        }
    }
}
