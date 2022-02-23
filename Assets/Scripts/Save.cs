using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip saveClip;
    bool save;
    public Transform lokacijaSejvke;
    public int BrojLevela;
    public GameObject ProgresSavedText;
    private void Start()
    {
        lokacijaSejvke = GetComponent<Transform>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            save = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            save = false;
        }
    }
    private void Update()
    {
        if (save == true && (Input.GetKeyDown(KeyCode.S)))
        {
            AS.PlayOneShot(saveClip);
            PlayerPrefs.SetFloat("SaveX", lokacijaSejvke.position.x);
            PlayerPrefs.SetFloat("SaveY", lokacijaSejvke.position.y);
            PlayerPrefs.SetFloat("SaveZ", lokacijaSejvke.position.z);
            PlayerPrefs.SetInt("saved", 1);
            PlayerPrefs.SetInt("Level", BrojLevela);
            Debug.Log("Progresijada sejvada!");
            ProgresSavedText.SetActive(true);
            Time.timeScale = 0.2f;
            Invoke("turnOffProgSavTxtBox", 0.2f);
        }

    }
    void turnOffProgSavTxtBox()
    {
        Time.timeScale = 1;
        ProgresSavedText.SetActive(false);
    }
}
