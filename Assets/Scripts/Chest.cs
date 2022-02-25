using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{ 
    public GameObject E;
    public Animation otvor;
    public Animator chest;
    public ParticleSystem ps;
    public AudioSource AS;
    public AudioClip getItem;
    private void Start()
    {
        otvor = gameObject.GetComponent<Animation>();
        chest = gameObject.GetComponent<Animator>();
    }
    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") && (Input.GetKey(KeyCode.E)))
        {
            PlayerPrefs.SetInt("gun",1);
            chest.Play("chest",0);
            ps.Play();
            AS.PlayOneShot(getItem);
            Destroy(E);
            GetComponent<BoxCollider>().enabled = false;

        }
        if (other.gameObject.tag == "Player")
        {
            E.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            E.SetActive(false);
        }
    }
}
