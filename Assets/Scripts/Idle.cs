using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : MonoBehaviour
{
    float timer = 2;

    private void Update()
    {
        if (!Input.anyKey)
        {
            timer -= Time.deltaTime;
            //Debug.Log("nediraš"); 
        }
        if (Input.anyKey)
        {
            timer = 2;
        }
        if(timer <= 0)
        {
            transform.Rotate(0, 100*Time.deltaTime, 0);
        }
    }

}
