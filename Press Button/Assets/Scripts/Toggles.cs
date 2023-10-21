using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggles : MonoBehaviour
{
    public bool[] ActualToggles;
    public GameObject Slider;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleDone(int i){
        if (ActualToggles[i] == true){
            ActualToggles[i] = false;
        } else {
       ActualToggles[i] = true;
       }
       

        if (  ActualToggles[0]== true &&  ActualToggles[2] == true &&  ActualToggles[4] == true &&  ActualToggles[1] == false &&  ActualToggles[3] == false &&  ActualToggles[3] == false){
            
            
            Debug.Log("Toggled");
            Slider.SetActive(true);
            
            }
    }


}
