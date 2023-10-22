using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationSelectorDropdown : MonoBehaviour
{
    public  Dropdown m_Dropdown;

public void ChangeLocationDropDown() {
        Debug.Log("DROP DOWN CHANGED");
      

        Debug.Log(m_Dropdown.options[m_Dropdown.value].text);
    }
}