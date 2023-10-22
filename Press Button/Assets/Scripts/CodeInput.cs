using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CodeInput : MonoBehaviour
{ 
public string password;
public  TMP_InputField inputField;
public GameObject[] FauxBG;


    // Start is called before the first frame update
   public void UpdatePassword(){
    if (inputField.text== password){
        Debug.Log("Access granted");
        for (int i =0; i < FauxBG.Length; i++){
        FauxBG[i].SetActive(false);
        }
        
    }


   }
}
