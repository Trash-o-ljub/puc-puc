using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{ 
    public GameObject E;
    
    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (Input.GetKey(KeyCode.E)))
        {
            PlayerPrefs.SetInt("gun",1);
            Destroy(this.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            E.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            E.SetActive(false);
        }
    }
}
