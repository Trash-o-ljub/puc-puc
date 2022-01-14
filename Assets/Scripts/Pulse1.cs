using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Pulse1 : MonoBehaviour
{ 
    public TextMeshProUGUI text;
    void Start()
    {
        StartCoroutine(Pulsate());
    }
    IEnumerator Pulsate()
    {
        for (float i = 0.9f; i <= 1f; i+=0.025f)
        {
            text.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForFixedUpdate();
        }
        for (float i = 1f; i >= 0.9f; i -= 0.025f)
        {
            text.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForFixedUpdate();
        }
        StartCoroutine(Pulsate());
    }
}
