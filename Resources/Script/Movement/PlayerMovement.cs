using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    UP, DOWN, RIGHT, LEFT
}

public class PlayerMovement : MonoBehaviour

{

    public float speed;
    Rigidbody2D rb;
    public Direction movingDir;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        switch (movingDir)
        {
            case Direction.UP:
                rb.velocity = new Vector2(0, speed * Time.fixedDeltaTime);
                rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                break;
            case Direction.DOWN:
                rb.velocity = new Vector2(0, -speed * Time.fixedDeltaTime);
                rb.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezeRotation;
                break;
            case Direction.RIGHT:
                rb.velocity = new Vector2(speed * Time.fixedDeltaTime, 0);
                rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                break;
            case Direction.LEFT:
                rb.velocity = new Vector2(-speed * Time.fixedDeltaTime, 0);
                rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
                break;
        }
    }
}

                     
                  
        
              

    
















