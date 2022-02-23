using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    bool save;
    public Transform lokacijaSejvke;
    public int BrojLevela;
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
        if (save == true && (Input.GetKeyDown(KeyCode.DownArrow) || (Input.GetKeyDown(KeyCode.S))))
        {
            PlayerPrefs.SetFloat("SaveX", lokacijaSejvke.position.x);
            PlayerPrefs.SetFloat("SaveY", lokacijaSejvke.position.y);
            PlayerPrefs.SetFloat("SaveZ", lokacijaSejvke.position.z);
            PlayerPrefs.SetInt("saved", 1);
            PlayerPrefs.SetInt("Level", BrojLevela);
        }

    }
}
