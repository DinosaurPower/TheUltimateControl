using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Switch : MonoBehaviour
{
   public Image [] sprites;
   public Text[] texts;
    public bool IsOn = false;

void Start(){
    for (int i = 0; i < sprites.Length; i++)
    {
        // Get the current color of the image
        Color thisColor = sprites[i].color;
        thisColor.a = 0.05f;  
         sprites[i].color = thisColor;
    }
  for (int l = 0; l < texts.Length; l++)
    {
        // Get the current color of the image
        Color thisColor = texts[l].color;
        thisColor.a = 0.05f;  
         texts[l].color = thisColor;
    }

}
public void ColorSwitch()
{
//    Debug.Log("Clicked");

    // Toggle the switch state
    IsOn = !IsOn;

    for (int i = 0; i < sprites.Length; i++)
    {
        // Get the current color of the image
        Color thisColor = sprites[i].color;

        // Modify the alpha component of the color
        if (IsOn)
        {
            thisColor.a = 1.0f;  // Fully visible
        }
        else
        {
            thisColor.a = 0.05f;  // Partially transparent
        }

        // Apply the modified color back to the image
        sprites[i].color = thisColor;
    }


     for (int l = 0; l < texts.Length; l++)
    {
        // Get the current color of the image
        Color thisColor = texts[l].color;
         // Modify the alpha component of the color
        if (IsOn)
        {
            thisColor.a = 1.0f;  // Fully visible
        }
        else
        {
            thisColor.a = 0.05f;  // Partially transparent
        }
         texts[l].color = thisColor;
        
    
    }

}
}

