using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackText : MonoBehaviour
{
    TextMesh MusicText;
    public AudioSource Sound;
    public AudioClip Track1;
    public AudioClip Track2;

    private void Start()
    {
        MusicText = GetComponent<TextMesh>();
    }
    void Update()
    {

        if (Sound.clip == Track1)
        {
            MusicText.text = "Music (Track 1)";
        }
        else if (Sound.clip == Track2)
        {
            MusicText.text = "Music (Track 2)";
        }
    }
}
