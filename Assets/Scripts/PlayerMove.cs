using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float runSpeed = 2;
    public float jumpSpeed = 3;
    public bool improvedJump = true;
    public float fallMultiplier = .5f;
    public float lowJumpMultiplier = 2f;


    Rigidbody2D rg2D;
    public SpriteRenderer spriteRenderer;
    public Animator animator;

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
            spriteRenderer.flipX = false; // mirar a la dreta
            animator.SetBool("Run", true); // canviar animació a Run

        } else if (Input.GetKey("a") || Input.GetKey("left")) {
            rg2D.velocity = new Vector2(-runSpeed, rg2D.velocity.y);
             spriteRenderer.flipX = true; // mirar a l'esquerra
             animator.SetBool("Run", true); // canviar animació a Run
        } else {
            rg2D.velocity = new Vector2(0, rg2D.velocity.y);
            animator.SetBool("Run", false); // canviar animació a idle
        }

        if (Input.GetKey("space") && CheckGround.isGrounded) {
            rg2D.velocity = new Vector2(rg2D.velocity.x, jumpSpeed);
        } 

        if (!CheckGround.isGrounded) {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        } else {
            animator.SetBool("Jump", false);
        }

        if (improvedJump) {
            if (rg2D.velocity.y < 0) {
                rg2D.velocity += Vector2.up * Physics2D.gravity.y * fallMultiplier * Time.deltaTime;
            }
            if (rg2D.velocity.y > 0 && !Input.GetKey("space")) {
                rg2D.velocity += Vector2.up * Physics2D.gravity.y * lowJumpMultiplier * Time.deltaTime;
            }
        }
    }
}
