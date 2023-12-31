using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;
    private AudioSource audio;
    
    
    void Start()
    {
        startPosition = transform.position;
        Launch();
        audio = GetComponent<AudioSource> ();
       
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        transform.position = startPosition;
        Launch();
    }
    private void Launch()
    {
        
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1; 
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Debug.Log("wall");
            audio.Play();
        }
    }
}
