using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Pulse : MonoBehaviour
{ 
    public TextMeshProUGUI text;
    public void Ajde()
    {
        StartCoroutine(Pulsate());
    }
    IEnumerator Pulsate()
    {
        for (float i = 1f; i <= 1.2f; i+=0.025f)
        {
            text.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForFixedUpdate();
        }
        for (float i = 1.2f; i >= 1f; i -= 0.025f)
        {
            text.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForFixedUpdate();
        }
        StartCoroutine(Pulsate());
    }
}
