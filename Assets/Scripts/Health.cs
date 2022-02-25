using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    public Slider slider;
    public GameObject OverScreen;
    public GameObject PlayerDead;
    public AudioSource AS;
    public AudioClip hurt;
    public AudioClip healthPickup;
    bool reset = false;
    public GameObject healthObject;
    private void Start()
    {
        healthObject = GameObject.FindGameObjectWithTag("Health");
    }
    private void Update()
    {
        if (health <= 0 && reset == false)
        {
            Time.timeScale = 0;
            OverScreen.SetActive(true);
            PlayerDead.SetActive(false);
        }     
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health = health - 10;
            slider.value = health;
            AS.PlayOneShot(hurt);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Health")
        {
            health = 100;
            AS.PlayOneShot(healthPickup);
            slider.value = health;
            healthObject.SetActive(false);
        }
    }
    public void MainMenu()
    {
        Debug.Log("stisnia si yes");
        reset = true;
        Time.timeScale = 1;
        //PlayerPrefs.SetInt("Health", maxHealth);
        SceneManager.LoadSceneAsync("MainMenu");
        
    }

    public void Load()
    {
        reset = true;
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("Level 1");
        //PlayerPrefs.SetInt("Health", 100);
        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"),0);
        Time.timeScale = 1;
    }
}
