using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundSO", menuName = "Scriptable Object/Sound Data")]
public class SoundSO : ScriptableObject
{
    [SerializeField] private string _name;
    public string Name { get { return _name; } }

    [SerializeField] private AudioClip _clip;
    public AudioClip Clip { get { return _clip; } }
}
