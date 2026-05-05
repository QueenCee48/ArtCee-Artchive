using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailViewController : MonoBehaviour
{
    public Text detailViewTxt; 
    public Text aboutTabTxt;
    public Text storyTabTxt;
	
    public Image detailViewImg; 
    public Image detailViewPage; 
    public Image detailViewAboutTab; 
    public Image detailViewStoryTab; 
    public Image detailViewCloseBtn;

    public BoxCollider2D[] smallViewColliders;

    public bool detailViewOpen;
    public bool aboutTabOpen;
    public bool storyTabOpen;

    public string aboutTxt;
    public string storyTxt;

    public SoundFXController sfxCntrlr;

    public void Start()
	{
		detailViewOpen = false;
        aboutTabOpen = false;
        storyTabOpen = false;

        aboutTxt = "";
        storyTxt = "";

        sfxCntrlr = GameObject.Find("SoundFX").GetComponent<SoundFXController>();
	}
	
	public void OpenDetailView(Sprite detailSprite, string aboutInfo, string storyInfo)
	{
        sfxCntrlr.PlayOpenDVSFX();
        
        detailViewOpen = true;
        aboutTabOpen = true;
        storyTabOpen = false;

        detailViewTxt.enabled = true;
        aboutTabTxt.enabled = true;
        storyTabTxt.enabled = true;
        
        detailViewImg.enabled = true;
        detailViewPage.enabled = true;
        detailViewAboutTab.enabled = true;
        detailViewStoryTab.enabled = true;
        detailViewCloseBtn.enabled = true;

		aboutTxt = aboutInfo;
        storyTxt = storyInfo;
        detailViewTxt.text = aboutTxt;
        detailViewImg.sprite = detailSprite;

        foreach (BoxCollider2D collider in smallViewColliders)
        {
            collider.enabled = false;
        }
    }
	
	public void CloseDetailView()
	{
		detailViewOpen = false;
        aboutTabOpen = false;
        storyTabOpen = false;

        detailViewTxt.enabled = false;
        aboutTabTxt.enabled = false;
        storyTabTxt.enabled = false;
        
        detailViewImg.enabled = false;
        detailViewPage.enabled = false;
        detailViewAboutTab.enabled = false;
        detailViewStoryTab.enabled = false;
        detailViewCloseBtn.enabled = false;

        aboutTxt = "";
        storyTxt = "";

        foreach (BoxCollider2D collider in smallViewColliders)
        {
            collider.enabled = true;
        }
	}
}
