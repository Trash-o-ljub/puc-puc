using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    
    void Start()
    {
        if ((PlayerPrefs.GetInt("gun") == 0)&& (PlayerPrefs.GetInt("saved") == 0))
        {
            GameObject Player = Resources.Load("Player") as GameObject;
            Instantiate(Player, new Vector3(-44, 27.5f, 0), Quaternion.identity);
        }
        if (((PlayerPrefs.GetInt("gun") == 1) && (PlayerPrefs.GetInt("saved") == 1))|| ((PlayerPrefs.GetInt("gun") == 0) && (PlayerPrefs.GetInt("saved") == 1)))
        {
            GameObject Player = Resources.Load("Player") as GameObject;
            Instantiate(Player, new Vector3(-7.5f, -1, 0), Quaternion.identity);
        }
    }
    


}
