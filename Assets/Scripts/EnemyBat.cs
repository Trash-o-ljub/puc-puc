using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBat : MonoBehaviour
{
    public Rigidbody rb;
    public float dir;
    public int enemyHealth = 2;
    public AudioClip hitSound;
    public GameObject child1;
    public GameObject child2;
    public GameObject child3;
    public GameObject child4;
    public Collider kolajder;
    public void Start()
    {
        rb = GetComponent<Rigidbody>();
        dir = 3;
        child1 = this.gameObject.transform.GetChild(0).gameObject;
        child2 = this.gameObject.transform.GetChild(1).gameObject;
        child3 = this.gameObject.transform.GetChild(2).gameObject;
        child4 = this.gameObject.transform.GetChild(3).gameObject;
        kolajder = GetComponent<SphereCollider>();
    }

    void Update()
    {
        var target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(target.transform);
        
        
    }
    void FixedUpdate()
    {
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
        {
            GetComponent<AudioSource>().PlayOneShot(hitSound);
            enemyHealth--;
            if (enemyHealth == 0) 
            {
                Debug.Log("umraäiömiö");
                child1.SetActive(false);
                child2.SetActive(false);
                child3.SetActive(false);
                child4.SetActive(false);
                kolajder.enabled = false;
            }
        }
    }
}
