using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearSaves : MonoBehaviour
{
    public void ClearSejvke()
    {
        PlayerPrefs.SetInt("saved", 0);
        PlayerPrefs.DeleteAll();
    }
}
