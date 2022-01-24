using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;
    public GameObject upitnik;
    public void TriggerDialog()
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
    }
    private void OnTriggerEnter(Collider Player)
    {
        FindObjectOfType<DialogManager>().StartDialog(dialog);
        upitnik.SetActive(false);
    }

}
