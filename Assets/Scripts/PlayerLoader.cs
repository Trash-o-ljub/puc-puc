using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject Player = Resources.Load("Player") as GameObject;
        Instantiate(Player);
    }

    
}
