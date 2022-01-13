using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    
    void Start()
    {
        if (PlayerPrefs.GetInt("gun") == 0)
        {
            GameObject Player = Resources.Load("Player") as GameObject;
            Instantiate(Player, new Vector3(-44, 27.5f, 0), Quaternion.identity);
        }
    }
    


}
