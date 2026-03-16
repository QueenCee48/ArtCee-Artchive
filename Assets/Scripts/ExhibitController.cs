using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExhibitController : MonoBehaviour
{
    string aboutTxt;
    string storyTxt;
    public Sprite detailViewSprite;

    public DetailViewController detailViewCntrlr;

    // Start is called before the first frame update
    void Start()
    {
        // detailViewCntrlr = GameObject.Find("DetailView").GetComponent<DetailViewController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        switch (gameObject.name)
        {
            case "RickSV":
                aboutTxt = "\n            <b><i>Rick x Simpsons</i></b> \n\n\n<b>Date:</b>  <i>April 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Rick (from Rick and Morty) would look like in the art style of The Simpsons.</i>";
                break;
        }
        detailViewCntrlr.OpenDetailView(detailViewSprite, aboutTxt, storyTxt);
    }

    // public void PassExhibitInfo()
    // {
    //     detailViewCntrlr.OpenDetailView(detailViewSprite, aboutTxt, storyTxt);
    // }
}
