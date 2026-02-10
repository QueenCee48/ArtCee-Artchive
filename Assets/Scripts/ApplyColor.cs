using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ApplyColor : MonoBehaviour
{
    public FlexibleColorPicker fcp;
    // public Material material;
    public Image item;
    public RectTransform saturationSlider;

    void Start()
    {
        saturationSlider.position = new Vector3(saturationSlider.position.x, 100, saturationSlider.position.z);
    }
    void Update()
    {
        item.color = fcp.color;
    }
}
