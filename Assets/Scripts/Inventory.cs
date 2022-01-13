using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventar;
    public GameObject gun;
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
    private void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("gun") == 1)
        {
            gun.SetActive(true);
        }
        else { gun.SetActive(false); }
    }
}
