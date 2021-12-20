using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed, jumpForce;
    public float Hmove;
    public bool isGround;
    public Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //gettanje kontroli
        Hmove = Input.GetAxis("Horizontal");

        if (isGround && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
        if (Hmove < 0)
        {
            transform.eulerAngles = new Vector3(0, -90, 0);

        }
        if (Hmove > 0)
        {
            transform.eulerAngles = new Vector3(0, 90, 0);
        }

        //paljenje animacija
        anim.SetFloat("Blend", Mathf.Abs(rb.velocity.x));
        anim.SetFloat("skok", rb.velocity.y);
        anim.SetBool("ground", isGround);
        
        //sprint
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 400;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 200;
        }
        
        //krauch
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1, 2, 1);
        }
    }
    //muvment
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Hmove * speed * Time.deltaTime, rb.velocity.y);
    }
    
    //kad smije skocit(glupo)
    void OnCollisionStay(Collision other)
    {
        isGround = true;
    }
    
    void OnCollisionExit(Collision other)
    {
        isGround = false;
    }
}
