using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutCntrlr : MonoBehaviour
{
    string aboutTxt;
    string storyTxt;
    public Sprite detailViewSprite;

    public DetailViewController detailViewCntrlr;
    public SoundFXController sfxCntrlr;

    // Start is called before the first frame update
    void Start()
    {
        sfxCntrlr = GameObject.Find("SoundFX").GetComponent<SoundFXController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // sfxCntrlr.PlayOpenDVSFX();

        aboutTxt = "Ciera Baucham\n\nArtist\nGraphic Designer\nFront-End Developer\n\n2026 Graduate of Georgia Gwinnett College\n\nBS: IT - Digital Media";
        storyTxt = "I have always been interested in art and technology. It wasn't until I attended Georgia Gwinnett College that I realized how much I enjoyed developing and designing. I created this to have one place where I could show all my abilities. This includes game design, graphic design and web development. I hope you enjoy and thank you for visitng ArtCee Artchive!";
        detailViewCntrlr.OpenDetailView(detailViewSprite, aboutTxt, storyTxt);
    }
}
