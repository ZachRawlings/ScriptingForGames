using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ding : MonoBehaviour
{

    public AudioSource myAudioSource;
    public AudioClip myAudioClip;

    private void OnCollisionEnter(Collision collision)
    {
        myAudioSource.PlayOneShot(myAudioClip);
    }
}
