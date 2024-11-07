using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMusic : MonoBehaviour
{
    public AudioSource Jazz;

    public void OnTriggerEnter(Collider other)
    {
        Jazz.Stop();


        
    }
    
}
