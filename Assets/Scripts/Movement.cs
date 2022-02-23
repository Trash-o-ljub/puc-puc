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
    AudioSource playerSounds;
    public AudioClip landSound;
    public AudioClip jump;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerSounds = GetComponent<AudioSource>();
    }

    void Update()
    {
        //gettanje kontroli
        Hmove = Input.GetAxis("Horizontal");

        if (isGround && Input.GetKeyDown(KeyCode.Space))
        {
            playerSounds.PlayOneShot(jump);
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
    
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Hmove * speed * Time.deltaTime, rb.velocity.y);
    }

    //kad smije skocit(glupo)
    void OnCollisionStay(Collision Floor)
    {
        if (Floor.gameObject.tag == "Floor")
        {
            isGround = true;
        }
    }

    void OnCollisionEnter(Collision Floor)
    {
        if (Floor.gameObject.tag == "Floor")
        {
            playerSounds.PlayOneShot(landSound,0.5f);
        }
    }

    void OnCollisionExit(Collision Floor)
    {
        if (Floor.gameObject.tag == "Floor")
        {
            isGround = false;
        }
    }
}
