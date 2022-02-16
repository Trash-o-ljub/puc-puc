using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInLevel : MonoBehaviour
{
    bool vrata;
    public GameObject Player;
    public Vector3 lokacia;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            vrata = true;
            Player = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            vrata = false;
            Player = other.gameObject;

        }
    }
    private void Update()
    {
        if (vrata==true && (Input.GetKeyDown(KeyCode.DownArrow) || (Input.GetKeyDown(KeyCode.S))))
        {
            Player.transform.position = lokacia; 
        }
        
    }
}
