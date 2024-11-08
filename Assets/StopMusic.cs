using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public AudioSource Sound;

    public void OnTriggerEnter(Collider other)
    {
        Sound.Stop();


        
    }
    
}
