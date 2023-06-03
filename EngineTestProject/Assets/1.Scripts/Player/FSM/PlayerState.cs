using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState : MonoBehaviour
{
    protected PlayerBrain _pBrain;

    protected float distance;

    [SerializeField] protected float attackDist;

    private void Awake() {
        
        _pBrain = GetComponentInParent<PlayerBrain>();
    }

    public virtual void TakeAction(GameObject target) { } //실행할 액션들을 정의할 곳
}
