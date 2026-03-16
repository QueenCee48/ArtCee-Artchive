using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailViewController : MonoBehaviour
{
    // place this script on an Empty Game Object
        // inside Game Object: detailViewImage (with sprite renderer), close btn (with button), detailViewPage (with sprite renderer), detailViewTxt (with text), detailViewTab (with sprite renderer)

    public Text detailViewTxt; 
    public Text aboutTabTxt;
    public Text storyTabTxt;
	
    public Image detailViewImg; 
    public Image detailViewPage; 
    public Image detailViewAboutTab; 
    public Image detailViewStoryTab; 
    public Image detailViewCloseBtn;

    public bool detailViewOpen;
    public bool aboutTabOpen;
    public bool storyTabOpen;

    public string aboutTxt;
    public string storyTxt;
	
	public void Start()
	{
		detailViewOpen = false;
        aboutTabOpen = false;
        storyTabOpen = false;

        aboutTxt = "";
        storyTxt = "";
	}
	
	public void OpenDetailView(Sprite detailSprite, string aboutInfo, string storyInfo)
	{
        detailViewOpen = true;
        aboutTabOpen = true;
        storyTabOpen = false;

        //enable image and text components in exhibit game object

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
	}

    // public void SwapDetailDataTabs() {
    //     if (aboutTabOpen && !storyTabOpen) {
    //         detailViewTxt.text = aboutTxt;
    //     }
    //     else if (!aboutTabOpen && storyTabOpen) {
    //         detailViewTxt.text = storyTxt;
    //     }
    // }
}
