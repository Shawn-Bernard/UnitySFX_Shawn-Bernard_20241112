using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DTrigger : MonoBehaviour
{
    public AudioSource Bird;
    // Start is called before the first frame update
    void Start()
    {
        Bird = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Bird.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        Bird.Stop();
        Bird.loop = false;
    }
    private void OnTriggerStay(Collider other)
    {
        Bird.loop = true;
        Bird.PlayDelayed(2.0f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
