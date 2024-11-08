using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioSource Sound;
    

    
    public void OnTriggerEnter(Collider other)
    {
        Sound.Pause();
        
        
        //Jazz.spatialBlend = 1;
    }
    public void OnTriggerExit(Collider other)
    {
        Sound.Play();
    }
    

}
