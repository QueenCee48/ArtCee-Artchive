using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterPreviewCntrlr : MonoBehaviour
{
    public List<Sprite> options;
    public Image previewSprite;

    public CharacterCustomizationCntrlr customizationCntrlr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        previewSprite.sprite = options[customizationCntrlr.optionIndex];
    }
}
