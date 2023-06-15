using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    SoundManager instance;

    private Dictionary<string, AudioClip> clipDic = new Dictionary<string, AudioClip>();
    [SerializeField] private List<SoundSO> soundSO = new List<SoundSO>();

    private void Awake() {
        
        // 싱글톤
        if (instance == null)
            instance = this;
        else
            Destroy(instance);

        // 딕셔너리에 SoundSO 넣어주기
        foreach (SoundSO sound in soundSO)
            clipDic.Add(sound.Name, sound.Clip);
    }
    
    // 사운드를 실행할 함수
    public void Sound(AudioSource _audio, AudioClip _clip, bool _loop, float _pitch = 1.0f) {

        _audio.clip = _clip;
        _audio.loop = _loop;
        _audio.pitch = _pitch;

        _audio.Play();
    }
}
