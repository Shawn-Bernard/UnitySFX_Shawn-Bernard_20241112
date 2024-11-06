using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    public AudioSource Jazz;

    public void Start()
    {
        Jazz = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        Jazz.Pause();
        
        //Jazz.spatialBlend = 1;
    }
    public void OnTriggerExit(Collider other)
    {
        Jazz.Play();
    }

}
