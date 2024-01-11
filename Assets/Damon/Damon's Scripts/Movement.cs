using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public KeyCode Left, Right, Up, Down;
    public float buildUp;
    public float maxSpeed;
    static int State;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        //left inputs
        if (Input.GetKey(Left))
        {
            State = 1;
            if (Input.GetKey(Up))
            {
                rb2d.AddForce(Vector2.left * buildUp);
                rb2d.AddForce(Vector2.up * buildUp);
            }
            if (Input.GetKey(Down))
            {
                rb2d.AddForce(Vector2.left * buildUp);
                rb2d.AddForce(Vector2.down * buildUp);
            }
            rb2d.AddForce(Vector2.left * buildUp);
        }

        //right inputs
        if (Input.GetKey(Right))
        {
            State = 2;
            if (Input.GetKey(Up))
            {
                rb2d.AddForce(Vector2.right * buildUp);
                rb2d.AddForce(Vector2.up * buildUp);
            }
            if (Input.GetKey(Down))
            {
                rb2d.AddForce(Vector2.right * buildUp);
                rb2d.AddForce(Vector2.down * buildUp);
            }
            rb2d.AddForce(Vector2.right * buildUp);
        }

        //up input
        if (Input.GetKey(Up))
        {
            
            rb2d.AddForce(Vector2.up * buildUp);
        }

        //down input
        if (Input.GetKey(Down))
        {
            
            rb2d.AddForce(Vector2.down * buildUp);
        }

        rb2d.velocity = new Vector2(Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed), Mathf.Clamp(rb2d.velocity.y, -maxSpeed, maxSpeed));
    }
}
