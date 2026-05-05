using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFXController : MonoBehaviour
{
    AudioSource audioSrc;

    public AudioClip clickSFX;
    public AudioClip openDVSFX;
    public AudioClip changeTabSFX;

    // Start is called before the first frame update
    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            audioSrc.clip = clickSFX;
            audioSrc.Play();
        }
    }

    public void PlayOpenDVSFX()
    {
        audioSrc.clip = openDVSFX;
        audioSrc.Play();
    }

    public void PlayChangeTabSFX()
    {
        audioSrc.clip = changeTabSFX;
        audioSrc.Play();
    }
}
