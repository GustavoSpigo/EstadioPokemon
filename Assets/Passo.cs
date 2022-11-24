using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Passo : MonoBehaviour
{
    public AudioClip somPasso;
    private AudioSource audioSource;
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void tocarPasso()
    {
        audioSource.clip = somPasso;
        audioSource.Play();
    }
}
