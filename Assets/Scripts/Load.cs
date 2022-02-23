using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public void Start()
    {
        if (PlayerPrefs.GetInt("Level") == 0)
        {
            
            Debug.Log("prva špilja");
        }
        if (PlayerPrefs.GetInt("Level") == 1)
        {
            
            Debug.Log("selendra");
        }
    }
    public void load()
    {
        if (PlayerPrefs.GetInt("Level") == 0)
        {
            SceneManager.LoadSceneAsync("Level 1");
        }
        if (PlayerPrefs.GetInt("Level") == 1)
        {
            SceneManager.LoadSceneAsync("LevelVillage");
        }
    }
}
