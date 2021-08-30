using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] private SoundSO soundSO;
    private AudioSource sound;

    private void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.clip = soundSO.Sound;
        sound.playOnAwake = soundSO.Play;
        if (soundSO.Play) sound.Play();
    }
}
