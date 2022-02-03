using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBat : MonoBehaviour
{
    public Rigidbody rb;
    public float dir;
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
    private void OnCollisionEnter(Collision other)
    {
        dir *= -1;
    }
}
