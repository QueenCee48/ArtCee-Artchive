using UnityEngine;
using UnityEngine.UI;

public class TabController : MonoBehaviour
{
    DetailViewController detailViewCntrlr;

    public Sprite selectedTabImg;
    public Sprite deselectedTabImg;

    public Image aboutTabImg;
    public Image storyTabImg;

    public SoundFXController sfxCntrlr;
    
    void Start()
    {
        detailViewCntrlr = GameObject.Find("DetailView").GetComponent<DetailViewController>();
        aboutTabImg = GameObject.Find("DetailViewAboutTab").GetComponent<Image>();
        storyTabImg = GameObject.Find("DetailViewStoryTab").GetComponent<Image>();
        sfxCntrlr = GameObject.Find("SoundFX").GetComponent<SoundFXController>();
    }

    void Update()
    {
        // Reset tab images if detail view is closed
        if (!detailViewCntrlr.detailViewOpen)
        {
            aboutTabImg.sprite = selectedTabImg;
            storyTabImg.sprite = deselectedTabImg;
        }
    }

    // Swaps the text and tab images in the detail view when a tab is clicked
    public void SwapDetailDataTabs() {
        sfxCntrlr.PlayChangeTabSFX();
        
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
