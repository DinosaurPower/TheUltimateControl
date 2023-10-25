using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
   public TextMeshPro mText;
   public GameObject TextFinale;
   public int counter;
    
    // Start is called before the first frame update
    void Start()
    {
      //  mText = TextFinale.GetComponent<TextMeshPro>();

    }

   public void ButtonPress(){


    counter++;
    Debug.Log(counter);

   }

   public void TextUpdate(){
    TextFinale.SetActive(true);
    mText.text = "You have clicked Red Button "+counter+ " times!";


   }
}
