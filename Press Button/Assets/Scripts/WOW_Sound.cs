using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WOW_Sound : MonoBehaviour
{
      public AudioClip[] Effects;
      public AudioSource audiosource;
    public void PlayRandom(){
        int r = Random.Range(0, Effects.Length);
         audiosource.clip = Effects[r];
          audiosource.Play(0);
        
    }
}
