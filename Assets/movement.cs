using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

     Rigidbody2D rb;
     SpriteRenderer sprite;


    [SerializeField] int JUMPHEIGHT = 20;
    [SerializeField] float HORIZONTALDIRECTIONSPEED = 7.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(dirX * HORIZONTALDIRECTIONSPEED, rb.velocity.y);
        if(dirX > 0)
        {
            sprite.flipX = false;
        }
        if (dirX < 0)
        {
            sprite.flipX = true;
        }

        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x , JUMPHEIGHT);
        }
    }
}
