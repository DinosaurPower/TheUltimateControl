using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Transparency_Toggle : MonoBehaviour
{
    public Image runner;
    public float reductionSpeed;


    // Update is called once per frame
    void Update()
    {
       Color thisColor = runner.color;
       thisColor.a -= reductionSpeed*Time.deltaTime;  
       runner.color = thisColor;
    }

    public void Refresh(){
        Color thisColor = runner.color;
       thisColor.a = 1f;
        runner.color = thisColor;
    }
}
