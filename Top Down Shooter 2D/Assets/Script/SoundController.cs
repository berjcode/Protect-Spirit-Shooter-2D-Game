using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
   
public AudioSource fireSound;


#region Instance


public static SoundController Instance {get; set;}


public void Awake()
{
    Instance=this;
}

#endregion
   
   
   
   


#region FireSoundSystem
      public AudioClip[]  clip;

    #endregion





#region  DeadEnemySoundSystem


public AudioClip[] deadEnemySound;



#endregion  


   
      
}
