using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed, jumpForce;
    public float Hmove;
    public float Vmove;
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

    }
    ////ljestve
    //void OnTriggerStay(Collider ljestve)
    //{
    //    Vmove = Input.GetAxisRaw("Vertical");
    //    if (Vmove > 0)
    //    {
    //        rb.velocity = new Vector2(Vmove * speed * Time.deltaTime, rb.velocity.x);
    //        rb.useGravity = false;
    //    }
    //}
    //void OnTriggerExit(Collider ljestve)
    //{
    //    rb.useGravity = true;
    //}
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
