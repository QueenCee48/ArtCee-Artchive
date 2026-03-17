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
            case "2PacSV":
                aboutTxt = "\n             <b><i>2Pac x Arthur</i></b> \n\n\n<b>Date:</b>  <i>June 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what 2Pac would look like in the art style of Arthur.</i>";
                break;
            case "ArianaSV":
                aboutTxt = "\n               <b><i>Ariana x TDI</i></b> \n\n\n<b>Date:</b>  <i>December 2022</i> \n\n<b>Tools:</b>  <i>Procreate, Vectornator</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Ariana Grande would look like in the art style of Total Drama Island.</i>";
                break;
            case "BillieSV":
                aboutTxt = "\n              <b><i>Billie x CNKND</i></b> \n\n\n<b>Date:</b>  <i>September 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Billie Eilish would look like in the art style of Code Name Kids Next Door.</i>";
                break;
            case "BretmanSV":
                aboutTxt = "\n              <b><i>Bretman x LS</i></b> \n\n\n<b>Date:</b>  <i>November 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Bretman Rock (beauty influencer) would look like in the art style of Lilo and Stitch.</i>";
                break;
            case "IceSpiceSV":
                aboutTxt = "\n            <b><i>Ice Spice x FOP</i></b> \n\n\n<b>Date:</b>  <i>March 2023</i> \n\n<b>Tools:</b>  <i>Procreate, Vectornator</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Ice Spice would look like in the art style of Fairly Odd Parents.</i>";
                break;
            case "JColeSV":
                aboutTxt = "\n         <b><i>J.Cole x Garfield</i></b> \n\n\n<b>Date:</b>  <i>December 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what J.Cole would look like in the art style of Garfield.</i>";
                break;
            case "JheneSV":
                aboutTxt = "\n               <b><i>Jhene x TS</i></b> \n\n\n<b>Date:</b>  <i>August 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Jhene Aiko would look like in the art style of Totally Spies.</i>";
                break;
            case "RickSV":
                aboutTxt = "\n           <b><i>Rick x Simpsons</i></b> \n\n\n<b>Date:</b>  <i>April 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Rick (from Rick and Morty) would look like in the art style of The Simpsons.</i>";
                break;
            case "UziSV":
                aboutTxt = "\n                    <b><i>Uzi x RB</i></b> \n\n\n<b>Date:</b>  <i>October 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is my interpretation of what Lil Uzi Vert would look like in the art style of Rowdyruff Boys from the Powerpuff Girls.</i>";
                break;
        }
        detailViewCntrlr.OpenDetailView(detailViewSprite, aboutTxt, storyTxt);
    }
}
