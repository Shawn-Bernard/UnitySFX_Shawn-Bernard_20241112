using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTrigger : MonoBehaviour
{
    public AudioSource Bird;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Bird.Play();
        Bird.loop = true;
    }
    public void OnTriggerExit(Collider other)
    {
        Bird.Stop();
        Bird.loop = false;
    }
    public void OnTriggerStay(Collider other)
    {
        Bird.loop = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
