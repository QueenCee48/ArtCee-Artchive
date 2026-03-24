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
            case "VectPortSV":
                aboutTxt = "\n              <b><i>Vector Portrait</i></b> \n\n\n<b>Date:</b>  <i>May 2025</i> \n\n<b>Tools:</b>  <i>Adobe Illustrator</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>This is a vector portrait of myself. I made a pixel portrait of my image and then made a vector version of the pixel version.</i>";
                break;
            case "LadyElegSV":
                aboutTxt = "\n              <b><i>Lady Elegance</i></b> \n\n\n<b>Date:</b>  <i>February 2025</i> \n\n<b>Tools:</b>  <i>Adobe Illustrator</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>I found a beautiful portrait on Pinterest and made a vector version as a color study for my Digital Design class.</i>";
                break;
            case "FireEyesSV":
                aboutTxt = "\n              <b><i>Fire Eyes</i></b> \n\n\n<b>Date:</b>  <i>January 2025</i> \n\n<b>Tools:</b>  <i>Adobe Photoshop, Adobe Illustrator</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>I found a really cool graphic on Pinterest that I wanted to recreate for my Digital Design class.</i>";
                break;
            case "HondaHighSV":
                aboutTxt = "\n              <b><i>Honda Highlights</i></b> \n\n\n<b>Date:</b>  <i>May 2025</i> \n\n<b>Tools:</b>  <i>Adobe Photoshop, Adobe InDesign</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>I found an infographic on Pinterest and wanted to recreate a version on the Honda Civic.</i>";
                break;
            case "BlueFeverSV":
                aboutTxt = "\n              <b><i>Blue Fever</i></b> \n\n\n<b>Date:</b>  <i>March 2025</i> \n\n<b>Tools:</b>  <i>Adobe Illustrator, Adobe Photoshop</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>I wanted to recreate a vibrant graphic piece I saw on Pinterest for my Digital Design class.</i>";
                break;
            case "EsthNewsSV":
                aboutTxt = "\n              <b><i>Esthetician News</i></b> \n\n\n<b>Date:</b>  <i>April 2025</i> \n\n<b>Tools:</b>  <i>Adobe Photoshop, Adobe InDesign</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>My sister was graduating and wanted this news graphic as a prop for her graduation photos.</i>";
                break;
            case "BotOLoveSV":
                aboutTxt = "\n              <b><i>Bottle Of Love</i></b> \n\n\n<b>Date:</b>  <i>February 2025</i> \n\n<b>Tools:</b>  <i>Adobe Illustrator</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An ambiguous image that includes a bottle, hearts, and mouths all in the same image in the spirit of valentines day.</i>";
                break;
            case "LayOCupidSV":
                aboutTxt = "\n              <b><i>Layers of Cupid</i></b> \n\n\n<b>Date:</b>  <i>February 2025</i> \n\n<b>Tools:</b>  <i>Adobe Illustrator</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>In the spirit of valentines day, this cupid is used to demonstrate the art of immersion.</i>";
                break;
            case "Vibe98SV":
                aboutTxt = "\n              <b><i>Vibe 98</i></b> \n\n\n<b>Date:</b>  <i>January 2025</i> \n\n<b>Tools:</b>  <i>Adobe Photoshop</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>My recreation of a 90's vibe graphic I found on Pinterest.</i>";
                break;
            case "EDCSV":
                aboutTxt = "\n              <b><i>Every Dollar Counts</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "FRVR22SV":
                aboutTxt = "\n              <b><i>Forever 22</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "FastTimesSV":
                aboutTxt = "\n              <b><i>Fast Times</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "TheDonSV":
                aboutTxt = "\n              <b><i>The Don</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "MOMMSV":
                aboutTxt = "\n              <b><i>Money On My Mind</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "ArchangelSV":
                aboutTxt = "\n              <b><i>Archangel</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "EarthAngelSV":
                aboutTxt = "\n              <b><i>Earth Angel</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "RightTimeSV":
                aboutTxt = "\n              <b><i>Right Time</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "LiveLifeSV":
                aboutTxt = "\n              <b><i>Live That Life</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "ElegEleSV":
                aboutTxt = "\n              <b><i>Elegant Elephant</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "CurlyQueenSV":
                aboutTxt = "\n              <b><i>Curly Queen</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "AngelSV":
                aboutTxt = "\n              <b><i>Angel</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "WisdomSV":
                aboutTxt = "\n              <b><i>Wisdom</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "LineOLoveSV":
                aboutTxt = "\n              <b><i>Lines of Love</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "RoleModelsSV":
                aboutTxt = "\n              <b><i>Role Models</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "TakeoffSV":
                aboutTxt = "\n              <b><i>Takeoff</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "PinkLemonsSV":
                aboutTxt = "\n              <b><i>Pink Lemons</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
            case "ComebackSV":
                aboutTxt = "\n              <b><i>The Comeback</i></b> \n\n\n<b>Date:</b>  <i></i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i></i>";
                break;
        }
        detailViewCntrlr.OpenDetailView(detailViewSprite, aboutTxt, storyTxt);
    }
}
