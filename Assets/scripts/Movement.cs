using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;
    private float moveInput;
    private bool isGrounded;

    public Transform feetPos;
    public float checkRadius;
    public LayerMask whatIsGround;

public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("moose");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveInput = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }

    void Update(){
        isGrounded = Physics2D.OverlapCircle(feetPos.position, checkRadius,whatIsGround);
    
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = Vector2.up * jumpForce;
        }
    
    }
}
