using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Sound", order = 1)]
public class SoundSO : ScriptableObject
{
    [SerializeField] private AudioClip sound;
    [SerializeField] private bool play;

    public bool Play { get => play; set => play = value; }
    public AudioClip Sound { get => sound; set => sound = value; }
}
