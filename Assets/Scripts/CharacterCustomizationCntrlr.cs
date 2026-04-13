using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class CharacterCustomizationCntrlr : MonoBehaviour
{
    public SpriteLibrary spriteLibrary;
    public SpriteResolver spriteResolver;

    public List<SpriteLibraryAsset> options = new List<SpriteLibraryAsset>();
    public int optionIndex;

    // Start is called before the first frame update
    void Start()
    {
        optionIndex = 0;

        spriteLibrary.spriteLibraryAsset = options[optionIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextOption()
    {
        optionIndex++;
        if (optionIndex >= options.Count)
        {
            optionIndex = 0;
        }
        
        spriteLibrary.spriteLibraryAsset = options[optionIndex];
    }

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
