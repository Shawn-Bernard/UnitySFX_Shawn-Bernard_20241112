using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackTwo : MonoBehaviour
{
    public AudioSource Sound;
    public AudioClip Track2;



    public void OnTriggerEnter(Collider other)
    {
        Sound.clip = Track2;
        Sound.Play();


    }



}
