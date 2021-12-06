using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turkey : MonoBehaviour
{
    static private Turkey S;
    private AudioSource m_AudioSource;

    private void Start()
    {
        S = this;
        m_AudioSource = GetComponent<AudioSource>();
        PlayTurkeySound();
    }

    public static void PlayTurkeySound()
    {
        S.m_AudioSource.Play();
    }
}
