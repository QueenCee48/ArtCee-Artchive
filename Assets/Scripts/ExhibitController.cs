using System;
using System.Collection;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExhibitController : MonoBehaviour
{
    // place this script on an Empty Game Object
        // inside Game Object: detailViewImage (with sprite renderer), close btn (with button), detailViewPage (with sprite renderer), detailViewTxt (with text), detailViewTab (with sprite renderer)

    public GameObject detailViewPrefab; //Set in unity editor

    public Text detailViewTxt; //Set in unity editor
	
    public SpriteRenderer detailViewImg; //Set in unity editor
    public SpriteRenderer detailViewPage; //Set in unity editor
    public SpriteRenderer detailViewTab; //Set in unity editor

    public Sprite selectedTabImg;
    public Sprite deselectedTabImg;

	public Sprite[] DVSprites; //Set in unity editor

    public bool detailViewOpen;
    public bool aboutTabOpen;
    public bool storyTabOpen;

    string aboutTxt;
    string storyTxt;
	
	public void start()
	{
		detailViewOpen = false;
        aboutTabOpen = false;
        storyTabOpen = false;

        aboutTxt = "";
        storyTxt = "";
	}
	
	public static void OpenDetailView()
	{
        detailViewOpen = true;
        aboutTabOpen = true;
        storyTabOpen = false;
        detailViewPage.enabled = true;

		switch (/*figure out what to switch here*/) 
		{
			case "RickSV" :
				//swap out the sprite
				detailViewImg.sprite = DVSprites[1];

                aboutTxt = "";
                storyTxt = "";
            
                
				

				break;
		}

        //enable image and text components in exhibit game object
        detailViewImg.enabled = true;
        detailViewTxt.enabled = true;
			
    }
	
	public static void CloseDetailView()
	{
		detailViewOpen = false;
        detailViewImg.enabled = false;
        detailViewTxt.enabled = false;
        aboutTxt = "";
        storyTxt = "";
	}

    public static void SwapDetailDataTabs() {
        if (aboutTabOpen && !storyTabOpen) {
            detailViewTxt = aboutTxt;
        }
        else if (!aboutTabOpen && storyTabOpen) {
            detailViewTxt = storyTxt;
        }
    }
}
