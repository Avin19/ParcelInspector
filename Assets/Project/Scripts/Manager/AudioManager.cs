using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : Singleton<AudioManager>
{


    [SerializeField] private AudioSource audioSource;

    protected override void Awake()
    {
        base.Awake();

        Debug.Log("GameManager Initialized");
    }
}
