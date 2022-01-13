using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door1 : MonoBehaviour
{
    public string SName;
    public GameObject player;
    public Transform SP;
    public void OnTriggerStay(Collider Player)
    {
        if ((Input.GetKey(KeyCode.DownArrow))||(Input.GetKey(KeyCode.S)))
        {
            SceneManager.LoadSceneAsync(SName);
            Gdje();
        }
        
    }
    public void Gdje()
    {
        player.transform.position = SP.transform.position;
    }

}
