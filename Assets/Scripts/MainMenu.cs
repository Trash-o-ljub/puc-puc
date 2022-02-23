using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void OpenScene(string SName)
    {
        SceneManager.LoadSceneAsync(SName);
        PlayerPrefs.SetInt("gun", 0);
    }
    public void ExitGame()
    {
        Invoke("MotajKablove", 1);
    }
    public void MotajKablove()
    {
        Application.Quit();
    }
}
