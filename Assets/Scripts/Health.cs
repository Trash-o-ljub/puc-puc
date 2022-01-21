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
    bool reset = false;
    
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
        }
        if (collision.gameObject.tag == "Health")
        {
            health = health + 10;
            slider.value = health;
        }
    }
    public void MainMenu()
    {
        reset = true;
        Time.timeScale = 1;
        //PlayerPrefs.SetInt("Health", maxHealth);
        SceneManager.LoadScene("MainMenu");

    }

    public void Load()
    {
        reset = true;
        Time.timeScale = 1;
        SceneManager.LoadScene("Level 1");
        //PlayerPrefs.SetInt("Health", 100);
        transform.position = new Vector3(PlayerPrefs.GetFloat("x"), PlayerPrefs.GetFloat("y"),0);
        Time.timeScale = 1;
    }
}
