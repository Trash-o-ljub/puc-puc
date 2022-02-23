using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zajebancija : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip HaHa;
    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.tag == "Player")
        {
            Instantiate(this.gameObject);
            AS.PlayOneShot(HaHa);
        }
    }
}
