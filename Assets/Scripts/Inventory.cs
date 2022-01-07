using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventar;   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventar.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            inventar.SetActive(false);
        }

    }
}
