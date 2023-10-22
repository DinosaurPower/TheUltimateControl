using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LocationSelectorDropdown : MonoBehaviour
{
    public  TMP_Dropdown m_Dropdown;

public void ChangeLocationDropDown() {
        Debug.Log("DROP DOWN CHANGED");
      

        Debug.Log(m_Dropdown.options[m_Dropdown.value].text);
    }
}