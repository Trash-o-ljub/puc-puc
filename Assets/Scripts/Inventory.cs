using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject inventar;
    public GameObject gun;
    public GameObject exitScreen;
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitScreen.SetActive(true);
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
    public void ExitGame()
    {
        Application.Quit();
    }
}
