using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (Input.GetKey(KeyCode.S)))
        {
            PlayerPrefs.SetInt("gun",1);
            Destroy(this.gameObject);
        }
    }

}
