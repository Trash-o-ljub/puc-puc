using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public AudioSource AS;
    public AudioClip nextMsgSound;

    public Text nameText;
    public Text dialogText;
    public Queue<string> sentences;
    public GameObject dialogBox;
    void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialog(Dialog dialog)
    {
        Debug.Log("starting conv with " + dialog.name);
        dialogBox.SetActive(true);
        Time.timeScale = 0.2f;
        nameText.text = dialog.name;
        sentences.Clear();
        foreach(string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        AS.PlayOneShot(nextMsgSound);
        if (sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
        dialogText.text = sentence;
    }
    void EndDialog()
    {
        Debug.Log("end of conv");
        dialogBox.SetActive(false);
        Time.timeScale = 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DisplayNextSentence();
        }
    }
}
