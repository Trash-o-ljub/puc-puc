using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBat : MonoBehaviour
{
    public Rigidbody rb;
    public float dir;
    public int enemyHealth = 2;
    public AudioClip hitSound;
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        dir = 3;
    }

    void Update()
    {
        var target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(target.transform);
        
        
    }
    void FixedUpdate()
    {
        //transform.localPosition += new Vector3(0, 0.1f, 0);
        rb.velocity = new Vector3(0, dir, 0);
    }
    void OnCollisionEnter(Collision Zid)
    {
        if (Zid.gameObject.tag == "Zid")
        {
            dir *= -1;
        }
        if (Zid.gameObject.tag == "Enemy")
        {
            dir *= -1;
        }
    }
    void OnTriggerEnter(Collider Bullet) 
    {
        if (Bullet.gameObject.tag == "Bullet")
        {GetComponent<AudioSource>().PlayOneShot(hitSound);
            enemyHealth--;
            if (enemyHealth == 0) 
            {
                
                Debug.Log("dali???");
                gameObject.SetActive(false);
            }
        }
    }
}
