using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class FollowPlayer : MonoBehaviour
{
    public Transform target;
    public float followDistance;
    public float speed;

    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(target.position, transform.position) < followDistance)
        {
            rb2D.velocity = (target.position - transform.position).normalized * speed;
        }
        if (rb2D.velocity.x < 0)
        {
            GetComponent<Animator>().SetInteger("State", 1);
        }
        else if (rb2D.velocity.x > 0)
        {
            GetComponent<Animator>().SetInteger("State", 2);
        }
        else
        {
            GetComponent<Animator>().SetInteger("State", 0);
        }
    }
}
