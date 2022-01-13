using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    
    public void Update()
    {
        transform.LookAt(target.transform.position);
        
    }
}
