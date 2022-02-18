using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatZid : MonoBehaviour
{
    

    void Update()
    {
        var target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(target.transform);
        
        
    }
    void OnTriggerEnter(Collider Bullet)
    {
        if (Bullet.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
        }
    }

}
