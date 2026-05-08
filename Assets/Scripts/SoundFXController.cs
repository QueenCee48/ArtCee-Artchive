using UnityEngine;

public class SoundFXController : MonoBehaviour
{
    AudioSource audioSrc;

    public AudioClip clickSFX;
    public AudioClip openDVSFX;
    public AudioClip changeTabSFX;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Plays the click sound every time the player clicks
        if (Input.GetButtonDown("Fire1"))
        {
            audioSrc.clip = clickSFX;
            audioSrc.Play();
        }
    }

    // Playes the whish sound fx when the detail view is opened
    public void PlayOpenDVSFX()
    {
        audioSrc.clip = openDVSFX;
        audioSrc.Play();
    }

    // plays the page flip sound fx when the player switches tabs in the detail view
    public void PlayChangeTabSFX()
    {
        audioSrc.clip = changeTabSFX;
        audioSrc.Play();
    }
}
