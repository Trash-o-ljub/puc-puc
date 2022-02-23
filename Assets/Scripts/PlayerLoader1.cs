using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader1 : MonoBehaviour
{
    
    void Start()
    {
        
            GameObject Player = Resources.Load("Player") as GameObject;
            Instantiate(Player, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
        
    }
    


}
