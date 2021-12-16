using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed, jumpForce;
    public float Hmove;
    public bool isGround;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        Hmove = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 400;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 200;
        }
        
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1, 2, 1);
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Hmove * speed * Time.deltaTime, rb.velocity.y);
    }
    
    void OnCollisionStay(Collision other)
    {
        isGround = true;
    }
    
    void OnCollisionExit(Collision other)
    {
        isGround = false;
    }
}
