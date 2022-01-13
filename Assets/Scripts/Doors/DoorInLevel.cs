using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInLevel : MonoBehaviour
{
    bool vrata;
    public GameObject Player;
    public Vector3 lokacia;
    private void OnTriggerEnter(Collider Player)
    {
        vrata = true;
    }
    private void OnTriggerExit(Collider Player)
    {
        vrata = false;
    }
    private void Update()
    {
        if (vrata==true && (Input.GetKeyDown(KeyCode.DownArrow) || (Input.GetKeyDown(KeyCode.S))))
        {
            Player.transform.position = lokacia; 
        }
        
    }
    private void FixedUpdate()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
}
