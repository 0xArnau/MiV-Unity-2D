using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpSpeed = 3;

    Rigidbody2D rg2D;

    // Start is called before the first frame update
    void Start()
    {
        rg2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d") || Input.GetKey("right")) {
            rg2D.velocity = new Vector2(runSpeed, rg2D.velocity.y);
        } else if (Input.GetKey("a") || Input.GetKey("left")) {
            rg2D.velocity = new Vector2(-runSpeed, rg2D.velocity.y);
        } else if (Input.GetKey("w") || Input.GetKey("up")) {
            rg2D.velocity = new Vector2(rg2D.velocity.x, jumpSpeed);
        } else {
            rg2D.velocity = new Vector2(0, rg2D.velocity.y);
        }
    }
}
