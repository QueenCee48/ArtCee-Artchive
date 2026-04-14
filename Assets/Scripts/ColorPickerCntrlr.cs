using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ColorPickerCntrlr : MonoBehaviour
{
    public float currentHue, currentSat, currentVal;

    public RawImage hueImg, satImg, valImg;
    public Slider hueSlider, satSlider, valSlider;
    public Texture2D hueTexture, satTexture, valTexture;
    public Image targetPreviewImg;
    public SpriteRenderer targetCharacterAsset;

    public Image eyePreviewImg;
    public SpriteRenderer eyeCharAsset;
    public Image hairPreviewImg;
    public SpriteRenderer hairCharAsset;
    public Image topPreviewImg;
    public SpriteRenderer topCharAsset;
    public Image botPreviewImg;
    public SpriteRenderer botCharAsset;
    public Image shoePreviewImg;
    public SpriteRenderer shoeCharAsset;

    public Image[] btnFills;
    bool anyBtnActive;

    // Start is called before the first frame update
    void Start()
    {
        CreateHueImage();
        CreateSatImage();
        CreateValImage();

        foreach (Image btnFill in btnFills)
        {
            btnFill.enabled = false;
        }

        anyBtnActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTargetImages();
    }

    private void CreateHueImage()
    {
        hueTexture = new Texture2D(1, 16);
        hueTexture.wrapMode = TextureWrapMode.Clamp;
        hueTexture.name = "HueTexture";

        for (int i = 0; i < hueTexture.height; i++)
        {
            hueTexture.SetPixel(0, i, Color.HSVToRGB((float)i / hueTexture.height, 1, 0.95f));
        }

        hueTexture.Apply();
        currentHue = 0;

        hueImg.texture = hueTexture;
    }

    private void CreateSatImage()
    {
        satTexture = new Texture2D(1, 16);
        satTexture.wrapMode = TextureWrapMode.Clamp;
        satTexture.name = "SatTexture";

        for (int i = 0; i < satTexture.height; i++)
        {
            satTexture.SetPixel(0, i, Color.HSVToRGB(currentHue, (float)i / satTexture.height, 0.5f));
        }

        satTexture.Apply();
        currentSat = 0;

        satImg.texture = satTexture;
    }

    private void CreateValImage()
    {
        valTexture = new Texture2D(1, 16);
        valTexture.wrapMode = TextureWrapMode.Clamp;
        valTexture.name = "ValTexture";

        for (int i = 0; i < valTexture.height; i++)
        {
            float value = (float)(valTexture.height - 1 - i) / (valTexture.height - 1);
            valTexture.SetPixel(0, i, Color.HSVToRGB(currentHue, 0.5f, value));
        }

        valTexture.Apply();
        currentVal = 1;

        valImg.texture = valTexture;
    }

    public void UpdateSat()
    {
        currentSat = satSlider.value;
    }

    public void UpdateVal()
    {
        currentVal = 1 - valSlider.value;
    }

    public void UpdateSVImages()
    {
        currentHue = hueSlider.value;

        for (int i = 0; i < satTexture.height; i++)
        {
            satTexture.SetPixel(0, i, Color.HSVToRGB(currentHue, (float)i / satTexture.height, 0.5f));
        }

        for (int i = 0; i < valTexture.height; i++)
        {
            float value = (float)(valTexture.height - 1 - i) / (valTexture.height - 1);
            valTexture.SetPixel(0, i, Color.HSVToRGB(currentHue, 0.5f, value));
        }

        satTexture.Apply();
        valTexture.Apply();
    }

    public void UpdateTargetImages()
    {
        if (targetPreviewImg == null || targetCharacterAsset == null || !anyBtnActive) return;

        targetPreviewImg.color = Color.HSVToRGB(currentHue, currentSat, currentVal);
        targetCharacterAsset.color = Color.HSVToRGB(currentHue, currentSat, currentVal);
    }

    private Image prevBtnFill;

    public void SetBtnFill(string btnFillName)
    {
        anyBtnActive = false;

        foreach (Image btnFill in btnFills)
        {
            if (btnFill.name == btnFillName)
            {
                btnFill.enabled = !btnFill.enabled;

                if (btnFill.enabled)
                {
                    anyBtnActive = true;

                    switch (btnFillName)
                    {
                        case "EyeBtnFill":
                            targetPreviewImg = eyePreviewImg;
                            targetCharacterAsset = eyeCharAsset;
                            break;
                        case "HairBtnFill":
                            targetPreviewImg = hairPreviewImg;
                            targetCharacterAsset = hairCharAsset;
                            break;
                        case "TopBtnFill":
                            targetPreviewImg = topPreviewImg;
                            targetCharacterAsset = topCharAsset;
                            break;
                        case "BottomBtnFill":
                            targetPreviewImg = botPreviewImg;
                            targetCharacterAsset = botCharAsset;
                            break;
                        case "ShoeBtnFill":
                            targetPreviewImg = shoePreviewImg;
                            targetCharacterAsset = shoeCharAsset;
                            break;
                    }
                }

                if (prevBtnFill != null && prevBtnFill != btnFill)
                {
                    prevBtnFill.enabled = false;
                }
                prevBtnFill = btnFill;
            }
        }

        if (!anyBtnActive)
        {
            ResetTargets();
        }
    }

    public void ResetTargets()
    {
        targetPreviewImg = null;
        targetCharacterAsset = null;
    }
}
