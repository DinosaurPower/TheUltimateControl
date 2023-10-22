using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LocationSelectorDropdown : MonoBehaviour
{
    public  TMP_Dropdown m_Dropdown;
    public Tracker tracker;
    public Image ImageThatRevealsCode;
    public Sprite NewImage;

void Start(){


    tracker= GetComponent <Tracker>();
    }
public void ChangeLocationDropDown() {
       
      

        Debug.Log(m_Dropdown.options[m_Dropdown.value].text);

        if (m_Dropdown.options[m_Dropdown.value].text == "Option C" && tracker.SliderRevealed == true){

            ImageThatRevealsCode.sprite = NewImage;
        }
    }
}