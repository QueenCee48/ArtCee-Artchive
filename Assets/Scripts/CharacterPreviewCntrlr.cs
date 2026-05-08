using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPreviewCntrlr : MonoBehaviour
{
    public List<Sprite> options;
    public Image previewSprite;

    public CharacterCustomizationCntrlr customizationCntrlr;

    void Update()
    {
        // Match the preview sprite to the currently selected option in the customization cotroller
        previewSprite.sprite = options[customizationCntrlr.optionIndex];
    }
}
