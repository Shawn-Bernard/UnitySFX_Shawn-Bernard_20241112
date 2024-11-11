using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackOne : MonoBehaviour
{
    public AudioSource Sound;
    public AudioClip Track1;



    public void OnTriggerEnter(Collider other)
    {
        Sound.clip = Track1;
        Sound.Play();

        
    }
    


}
