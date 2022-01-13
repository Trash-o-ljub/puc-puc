using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string SName;
    
    private void OnTriggerStay(Collider Player)
    {
        if ((Input.GetKey(KeyCode.DownArrow))||(Input.GetKey(KeyCode.S)))
        {
            SceneManager.LoadSceneAsync(SName);
            
        }
        
    }
    

}
