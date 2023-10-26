using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DoubleDoor : MonoBehaviour
{
    public Double_Sliders GateSliders;
    public Slider sliderR;
    public Slider sliderL;
    public Transform GateR;
    public Transform GateL;
    private Vector3 initialPositionR;
    private Vector3 initialPositionL;
    public float moveSpeed = 5f;
    public bool Escaping;
    public Animator anim;
    public Counter counter;
    // Start is called before the first frame update
    void Start()
    {
            GateSliders = GetComponent<Double_Sliders>();
        initialPositionR = GateR.position;
        initialPositionL = GateL.position;
        
    }

    // Update is called once per frame
    void Update()
    {
         float sliderValueR = sliderR.value;
        float sliderValueL = sliderL.value;
        
        

        if (GateSliders.Opened == true){
            
            
           
            
             Vector3 moveDirectionR = Vector3.right;
             Vector3 moveDirectionL = Vector3.left;
            Vector3 targetPositionR = initialPositionR + moveDirectionR * sliderValueR * moveSpeed * Time.deltaTime*2000;
            Vector3 targetPositionL = initialPositionL + moveDirectionL * sliderValueL * moveSpeed * Time.deltaTime*2000;
             GateR.position = Vector3.MoveTowards(GateR.position, targetPositionR, moveSpeed * Time.deltaTime);
              GateL.position = Vector3.MoveTowards(GateL.position, targetPositionL, moveSpeed * Time.deltaTime);
           
                if (sliderValueR >=1 && sliderValueL >=1){
                Escaping = true;
                anim.SetTrigger("CanEscape 0");
                AnimatorStateInfo currentAnimationState = anim.GetCurrentAnimatorStateInfo(0);
        
                if (currentAnimationState.IsName("IsFree"))
        {
                        counter.TextUpdate();
                  
           
        
        }
             
    }
}
}
}
