using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gasiSeriousPanel : MonoBehaviour
{
    public AudioSource AS;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            AS.pitch = Time.timeScale = 1;

            this.gameObject.SetActive(false);
        }
    }
    public void GasiGaBokteUbio() { this.gameObject.SetActive(false); }
}
