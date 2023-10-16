using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColorModifier : MonoBehaviour
{
    public Image image;
    public Slider red;
    public Slider green;
    public Slider blue;

    public void OnEdit()
    {
        Color color = image.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        image.color = color;
    }
}
