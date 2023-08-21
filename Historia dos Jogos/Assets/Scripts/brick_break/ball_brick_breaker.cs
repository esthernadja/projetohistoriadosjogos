using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_brick_breaker : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inPlay;
    public Transform paddle;
    public float speed;
    public AudioSource bluebrick;
    public AudioSource greenbrick;
    public AudioSource yellowbrick;
    public AudioSource orangebrick;
    public AudioSource darkerorangebrick;
    public AudioSource redbrick;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
                       
    }

    // Update is called once per frame
    void Update()
    {
        if (!inPlay)
        {
            transform.position = paddle.position;
        }
        if (Input.GetButtonDown("Jump") && !inPlay)
        {
            inPlay = true;
            rb.AddForce(Vector2.up * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bottom"))
        {
            Debug.Log("Ball Hit the bottom of the screen");
            rb.velocity = Vector2.zero;
            inPlay = false;
        }
    }

    void OnCollisionEnter2D(Collision2D brick)
    {
        
        if(brick.gameObject.tag == "BlueBrick")
        {
            Destroy (brick.gameObject);
            bluebrick.Play();
        }
        else if(brick.gameObject.tag == "GreenBrick")
        {
            Destroy (brick.gameObject);
            greenbrick.Play();
        }
        else if(brick.gameObject.tag == "OrangeBrick")
        {
            Destroy (brick.gameObject);
            orangebrick.Play();
        }
        else if(brick.gameObject.tag == "DarkerOrangeBrick")
        {
            Destroy (brick.gameObject);
            darkerorangebrick.Play();
        }
        else if(brick.gameObject.tag == "YellowBrick")
        {
            Destroy (brick.gameObject);
            yellowbrick.Play();
        }
        else if(brick.gameObject.tag == "RedBrick")
        {
            Destroy (brick.gameObject);
            redbrick.Play();
        }
        

    }
}
