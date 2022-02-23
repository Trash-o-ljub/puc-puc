using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearSaves : MonoBehaviour
{
    public AudioSource AS;
    public GameObject AreYouSeriousPanel;
    public void paliSeriousPanel()
    {
        AreYouSeriousPanel.SetActive(true);
    }
    public void YesSerious()
    {
        PlayerPrefs.SetInt("saved", 0);
        PlayerPrefs.DeleteAll();
        AS.pitch = Time.timeScale = 1;

        AreYouSeriousPanel.SetActive(false);
    }

}
