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
                aboutTxt = "\n              <b><i>Every Dolla Counts</i></b> \n\n\n<b>Date:</b>  <i>November 2020</i> \n\n<b>Tools:</b>  <i>Adobe Illustrator, Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>My illustrative interpretation of a character based on a roll of money for a small brand known as EDC.</i>";
                break;
            case "FRVR22SV":
                aboutTxt = "\n              <b><i>Forever 22</i></b> \n\n\n<b>Date:</b>  <i>January 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>I put this together with the given photo of the rapper and a list of words they wanted in the background.</i>";
                break;
            case "FastTimesSV":
                aboutTxt = "\n              <b><i>Fast Times</i></b> \n\n\n<b>Date:</b>  <i>January 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An illustration done based on a picture of the artist and the request for beautiful women in the background.</i>";
                break;
            case "TheDonSV":
                aboutTxt = "\n              <b><i>The Don</i></b> \n\n\n<b>Date:</b>  <i>October 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An illustrative cover with Black Caesar as the provided inspiration.</i>";
                break;
            case "MOMMSV":
                aboutTxt = "\n              <b><i>Money On My Mind</i></b> \n\n\n<b>Date:</b>  <i>December 2020</i> \n\n<b>Tools:</b>  <i></i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A bright playful play on the phrase 'money on my mind'.</i>";
                break;
            case "ArchangelSV":
                aboutTxt = "\n              <b><i>Archangel</i></b> \n\n\n<b>Date:</b>  <i>September 2024</i> \n\n<b>Tools:</b>  <i>Procreate, Canva</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>The dark side of a two part angel series.</i>";
                break;
            case "EarthAngelSV":
                aboutTxt = "\n              <b><i>Earth Angel</i></b> \n\n\n<b>Date:</b>  <i>July 2024</i> \n\n<b>Tools:</b>  <i>Procreate, Canva</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>The light side of a two part angel series.</i>";
                break;
            case "RightTimeSV":
                aboutTxt = "\n              <b><i>Right Time</i></b> \n\n\n<b>Date:</b>  <i>April 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An illustrative work based on an image of the artist and their car with the request for a cityscape in the background.</i>";
                break;
            case "LiveLifeSV":
                aboutTxt = "\n              <b><i>Live That Life</i></b> \n\n\n<b>Date:</b>  <i>October 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>My interpretation of a party scene including a cameo of the artist.</i>";
                break;
            case "ElegEleSV":
                aboutTxt = "\n              <b><i>Elegant Elephant</i></b> \n\n\n<b>Date:</b>  <i>June 2020</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An illustration of an elephant with a lotus headress and smoke rings for a small hookah business.</i>";
                break;
            case "CurlyQueenSV":
                aboutTxt = "\n              <b><i>Curly Queen</i></b> \n\n\n<b>Date:</b>  <i>October 2020</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A cartoonized version of a portrait.</i>";
                break;
            case "AngelSV":
                aboutTxt = "\n              <b><i>Angel</i></b> \n\n\n<b>Date:</b>  <i>June 2023</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An angel created from a photo provided.</i>";
                break;
            case "WisdomSV":
                aboutTxt = "\n              <b><i>Wisdom</i></b> \n\n\n<b>Date:</b>  <i>March 2021</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An illustration of sloths to be printed on a blanket.</i>";
                break;
            case "LineOLoveSV":
                aboutTxt = "\n              <b><i>Lines of Love</i></b> \n\n\n<b>Date:</b>  <i>February 2024</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An outline of a couple's photo to be embroidered on a hoodie for Valentine's day.</i>";
                break;
            case "RoleModelsSV":
                aboutTxt = "\n              <b><i>Role Models</i></b> \n\n\n<b>Date:</b>  <i>September 2023</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>Cartoonized versions of two sports players.</i>";
                break;
            case "TakeoffSV":
                aboutTxt = "\n              <b><i>Takeoff</i></b> \n\n\n<b>Date:</b>  <i>February 2024</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An illustration of the clients car for a t-shirt design.</i>";
                break;
            case "PinkLemonsSV":
                aboutTxt = "\n              <b><i>Pink Lemonade</i></b> \n\n\n<b>Date:</b>  <i>March 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>An illustration to demonstrate friendship for a small embroidery company named Pink Lemons.</i>";
                break;
            case "ComebackSV":
                aboutTxt = "\n              <b><i>The Comeback</i></b> \n\n\n<b>Date:</b>  <i>September 2024</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A graphic for breast cancer awareness t-shirts.</i>";
                break;
            case "EDSV":
                aboutTxt = "\n              <b><i>Evergreen Dreams</i></b> \n\n\n<b>Date:</b>  <i>January 2025</i> \n\n<b>Tools:</b>  <i>Affinity Designer, Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo for Evergreen Dreams Floral Studio. Features flowers around the main shape.</i>";
                break;
            case "PLSV":
                aboutTxt = "\n              <b><i>Pink Lemons</i></b> \n\n\n<b>Date:</b>  <i>December 2020</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo for Pink Lemons Embroidery. Features a needle and thread around the 'PL'.</i>";
                break;
            case "IHUSV":
                aboutTxt = "\n              <b><i>iHelpU</i></b> \n\n\n<b>Date:</b>  <i>July 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo a small company called iHelpU. Features a sloth hugging a shopping bag.</i>";
                break;
            case "TESV":
                aboutTxt = "\n              <b><i>Tuk Entertainment</i></b> \n\n\n<b>Date:</b>  <i>May 2024</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo for a company called Tuk Entertainment.</i>";
                break;
            case "WOSV":
                aboutTxt = "\n              <b><i>Walden's Outdoors</i></b> \n\n\n<b>Date:</b>  <i>September 2024</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo for a landscaping company called Walden's Outdoors.</i>";
                break;
            case "BESV":
                aboutTxt = "\n              <b><i>Baucham Elite</i></b> \n\n\n<b>Date:</b>  <i>March 2024</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo for a small sports store called Baucham Elite.</i>";
                break;
            case "AC2SV":
                aboutTxt = "\n              <b><i>ArtCee V.2</i></b> \n\n\n<b>Date:</b>  <i>February 2024</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo created for my Digital Design class for my artist name ArtCee.</i>";
                break;
            case "ACSV":
                aboutTxt = "\n              <b><i>Piece of ArtCee</i></b> \n\n\n<b>Date:</b>  <i>January 2022</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A puzzle piece logo created from the shape of 3D letters A and C for my artist name ArtCee.</i>";
                break;
            case "LCCSV":
                aboutTxt = "\n              <b><i>Larey Carl Choice</i></b> \n\n\n<b>Date:</b>  <i>March 2026</i> \n\n<b>Tools:</b>  <i>Procreate</i> \n\n<b>Artist:</b>  <i>Ciera Baucham</i> \n\n<b>Medium:</b>  <i>Digital Art</i>";
                storyTxt = "\n\n<i>A logo for a small family owned business called Larey Carl Choice.</i>";
                break;
        }
        detailViewCntrlr.OpenDetailView(detailViewSprite, aboutTxt, storyTxt);
    }
}
