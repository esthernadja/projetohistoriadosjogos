using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_brick_break : MonoBehaviour
{
    public float speed;
    public float rightScreenEdge;
    public float leftScreenEdge;
    private AudioSource audio;
    
    

        void Start()
    {
        audio = GetComponent<AudioSource> ();
    }

       void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontal * Time.deltaTime * speed);

        //limitando movimento, barrando o paddle
        if(transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector2(leftScreenEdge, transform.position.y);
        }
        if (transform.position.x > rightScreenEdge)
        {
            transform.position = new Vector2(rightScreenEdge, transform.position.y);
        }


       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        { 
            Debug.Log("Sound");
            audio.Play();
        }

    }
    
}
