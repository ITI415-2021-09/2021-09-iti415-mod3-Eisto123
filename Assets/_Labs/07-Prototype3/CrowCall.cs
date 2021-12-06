using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowCall : MonoBehaviour
{
    private AudioSource m_AudioSource;
    private Animator animator;
    public float animationPlayTime = 2;
    public float nextTime = 0;
    // Update is called once per frame

    private void Start()
    {

        animator = GetComponent<Animator>();
        m_AudioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Time.time > nextTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                animator.SetBool("Called", true);
                PlayCrowSound();
                nextTime = Time.time + animationPlayTime;
            }
        }
        else
        {
            animator.SetBool("Called", false);
            Turkey.PlayTurkeySound();
        }

    }

    private void PlayCrowSound() 
    {
        m_AudioSource.Play();
    }
 }
