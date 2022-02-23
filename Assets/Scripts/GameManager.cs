using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.GetInt("gun") == 1 && PlayerPrefs.GetInt("Saved") == 1)
        {
            float LoadX = PlayerPrefs.GetFloat("SaveX");
            float LoadY = PlayerPrefs.GetFloat("SaveY");
            float LoadZ = PlayerPrefs.GetFloat("SaveZ");
            GameObject Player = Resources.Load("Player") as GameObject;
            Instantiate(Player, new Vector3(LoadX, LoadY, LoadZ), Quaternion.identity);
        }
    }
}
