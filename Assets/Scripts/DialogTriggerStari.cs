using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTriggerStari : MonoBehaviour
{
    public Dialog dialog;
    
    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
    public void OnCollisionStay(Collision other)
    {
        if ((other.gameObject.tag == "Player") && (Input.GetKey(KeyCode.E)))
        {
            FindObjectOfType<DialogManager>().StartDialog(dialog);
        }
    }
    
}
