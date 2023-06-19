using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIAction : MonoBehaviour
{
    protected AIBrain _aiBrain;
    protected Animator _animator;
    protected Animation _animation;
    [SerializeField] protected float speed; // 특정 상태의 속도

    protected virtual void Awake() {

        _aiBrain = GetComponentInParent<AIBrain>();
        _animator = GetComponentInParent<Animator>();
        _animation = GetComponentInParent<Animation>();
    }

    public abstract void TakeAction(); // 특정 상태의 액션
}   
