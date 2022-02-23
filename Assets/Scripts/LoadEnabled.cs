using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadEnabled : MonoBehaviour
{
    public GameObject LoadDugmence;
    private void Update()
    {
        if (PlayerPrefs.GetInt("saved") == 1)
        {
            LoadDugmence.SetActive(true);
        }
        if (PlayerPrefs.GetInt("saved") == 0)
        {
            LoadDugmence.SetActive(false);
        }
    }
}
