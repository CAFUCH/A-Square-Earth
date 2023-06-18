using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIAction : MonoBehaviour
{
    protected Animator _animator;
    protected AIBrain _aiBrain;
    [SerializeField] protected float speed; // 특정 상태의 속도

    protected virtual void Awake() {

        _animator = GetComponentInParent<Animator>();
        _aiBrain = GetComponentInParent<AIBrain>();
    }

    public abstract void TakeAction(); // 특정 상태의 액션
}   
