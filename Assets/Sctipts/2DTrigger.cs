using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DTrigger : MonoBehaviour
{
    public AudioSource Sound;



    private void OnTriggerEnter(Collider other)
    {
        Sound.spatialBlend = 0;
    }


}
