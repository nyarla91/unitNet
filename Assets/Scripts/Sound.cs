using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static Sound Component;
    [SerializeField] private AudioSource _audioSource;

    public AudioClip win;
    public AudioClip lose;
    public AudioClip platePressed;
    public AudioClip plateReleased;
    public AudioClip control;

    private void Awake()
    {
        Component = this;
    }

    public void Play(AudioClip sound)
    {
        _audioSource.PlayOneShot(sound);
    }
}