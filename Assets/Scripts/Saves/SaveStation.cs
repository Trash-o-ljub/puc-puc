using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStation : MonoBehaviour
{
    bool save;
    public GameObject Player;
    
    private void OnTriggerEnter(Collider Player)
    {
        save = true;
    }
    private void OnTriggerExit(Collider Player)
    {
        save = false;
    }
    private void Update()
    {
        if (save == true && (Input.GetKeyDown(KeyCode.DownArrow) || (Input.GetKeyDown(KeyCode.S))))
        {
            PlayerPrefs.SetFloat("x", Player.transform.position.x);
            PlayerPrefs.SetFloat("y", Player.transform.position.y);
        }

    }
    
    private void FixedUpdate()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
}
