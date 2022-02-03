using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    

    void Update()
    {
        var target = GameObject.FindGameObjectWithTag("Player");
        transform.LookAt(target.transform);
        
        
    }
    
}
