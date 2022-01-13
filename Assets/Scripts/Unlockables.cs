using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockables : MonoBehaviour
{
    public GameObject gun;
    public void FixedUpdate()
    {
        if (PlayerPrefs.GetInt("gun") == 0)
        {
            gun.SetActive(false);
        }
        if (PlayerPrefs.GetInt("gun") > 0)
        {
            gun.SetActive(true);
        }
    }
}
