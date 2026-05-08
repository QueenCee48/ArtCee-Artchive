using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class CharacterCustomizationCntrlr : MonoBehaviour
{
    public SpriteLibrary spriteLibrary;
    public SpriteResolver spriteResolver;

    public List<SpriteLibraryAsset> options = new List<SpriteLibraryAsset>();
    public int optionIndex;

    void Start()
    {
        optionIndex = 0;

        spriteLibrary.spriteLibraryAsset = options[optionIndex];
    }

    // Get the next option in the list and update the sprite library to the new option
    public void NextOption()
    {
        optionIndex++;
        if (optionIndex >= options.Count)
        {
            optionIndex = 0;
        }
        
        spriteLibrary.spriteLibraryAsset = options[optionIndex];
    }

    // Get the previous option in the list and update the sprite library to the new option
    public void PrevOption()
    {
        optionIndex--;
        if (optionIndex < 0)
        {
            optionIndex = options.Count - 1;
        }
        
        spriteLibrary.spriteLibraryAsset = options[optionIndex];
    }
}
