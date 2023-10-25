using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Double_Sliders : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Transform Gate;
    public bool Opened;
    public float moveSpeed = 5f;
    public Tracker tracker;
    private Vector3 initialPosition;
   

    void Start(){
        tracker = GetComponent<Tracker>();
        initialPosition = Gate.position;

    }
    // Update is called once per frame
    void Update()
    {
        float sliderValue1 = slider1.value;
        float sliderValue2 = slider2.value;
        
        

        if (tracker.ButtonsClicked== true && slider1.value >= 1&& slider2.value>=1){
            
            
           
            
             Vector3 moveDirection = Vector3.up;
            Vector3 targetPosition = initialPosition + moveDirection * (sliderValue1 * sliderValue2) * moveSpeed * Time.deltaTime*2000;
             Gate.position = Vector3.MoveTowards(Gate.position, targetPosition, moveSpeed * Time.deltaTime);
             Debug.Log(targetPosition);
             Opened = true;
             }
             
          
    }
}
