using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle_brick_break : MonoBehaviour
{
    public float speed;
    public float rightScreenEdge;
    public float leftScreenEdge;

        void Start()
    {
        
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
}
