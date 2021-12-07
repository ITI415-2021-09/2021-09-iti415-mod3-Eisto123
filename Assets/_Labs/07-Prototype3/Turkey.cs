using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turkey : MonoBehaviour
{
    private AudioSource m_AudioSource;
    static public bool turkeySound;

    private void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();
        PlayTurkeySound();
        
    }
    private void Update()
    {
        if (turkeySound)
        {
            PlayTurkeySound();
            turkeySound = false;
        }
    }
    void PlayTurkeySound()
    {
        m_AudioSource.Play();
    }
}
