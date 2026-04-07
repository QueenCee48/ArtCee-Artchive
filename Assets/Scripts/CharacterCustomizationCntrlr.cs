using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D.Animation;

public class CharacterCustomizationCntrlr : MonoBehaviour
{
    public SpriteLibrary spriteLibrary;
    public SpriteResolver spriteResolver;
    public SpriteLibraryAsset option1;
    public SpriteLibraryAsset option2;

    private List<SpriteLibraryAsset> options;
    public int optionIndex;

    // Start is called before the first frame update
    void Start()
    {
        optionIndex = 0;
        options = new List<SpriteLibraryAsset> { option1, option2 };

        spriteLibrary.spriteLibraryAsset = options[optionIndex];

        if (gameObject.name == "skin") {
            spriteResolver.SetCategoryAndLabel("body", "S_Idle_1");
        }
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
        
        ApplyOption();
    }

    public void PrevOption()
    {
        optionIndex--;
        if (optionIndex < 0)
        {
            optionIndex = options.Count - 1;
        }
        
        ApplyOption();
    }

    void ApplyOption()
    {
        spriteLibrary.spriteLibraryAsset = options[optionIndex];

        if (gameObject.name == "skin") {
            spriteResolver.SetCategoryAndLabel("body", spriteResolver.GetLabel());
        }
    }
}
