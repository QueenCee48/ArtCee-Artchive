using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    DetailViewController detailViewCntrlr;

    public Sprite selectedTabImg;
    public Sprite deselectedTabImg;

    public Image aboutTabImg;
    public Image storyTabImg;
    
    // Start is called before the first frame update
    void Start()
    {
        detailViewCntrlr = GameObject.Find("DetailView").GetComponent<DetailViewController>();
        aboutTabImg = GameObject.Find("DetailViewAboutTab").GetComponent<Image>();
        storyTabImg = GameObject.Find("DetailViewStoryTab").GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!detailViewCntrlr.detailViewOpen)
        {
            aboutTabImg.sprite = selectedTabImg;
            storyTabImg.sprite = deselectedTabImg;
        }
    }

    public void SwapDetailDataTabs() {
        if (gameObject.name == "DetailViewAboutTab") {
            detailViewCntrlr.aboutTabOpen = true;
            detailViewCntrlr.storyTabOpen = false;
            detailViewCntrlr.detailViewTxt.text = detailViewCntrlr.aboutTxt;
            aboutTabImg.sprite = selectedTabImg;
            storyTabImg.sprite = deselectedTabImg;
        }
        else if (gameObject.name == "DetailViewStoryTab") {
            detailViewCntrlr.aboutTabOpen = false;
            detailViewCntrlr.storyTabOpen = true;
            detailViewCntrlr.detailViewTxt.text = detailViewCntrlr.storyTxt;
            aboutTabImg.sprite = deselectedTabImg;
            storyTabImg.sprite = selectedTabImg;
        }
    }
}
