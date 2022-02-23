using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AudioRIVAJNSELEKTA : MonoBehaviour
{
    public AudioClip menuSelectSound;
    public AudioClip menuConfirmSound;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void menuSelect()
    {
        audioSource.PlayOneShot(menuSelectSound);
    }
    public void menuConfirm()
    {
        audioSource.PlayOneShot(menuConfirmSound);
    }
    public void clearPlayerPrefs()
    {
        audioSource.PlayOneShot(menuConfirmSound);
        audioSource.pitch = Time.timeScale = 0.2f;
    }
}
