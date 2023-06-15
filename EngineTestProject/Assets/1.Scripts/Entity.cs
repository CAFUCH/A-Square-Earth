using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour, IDamageable
{
    protected Animator _animator;

    [SerializeField] protected float hp, maxHp;
    [SerializeField] protected float walkSpeed, runSpeed;
    [SerializeField] protected float damage;
    [SerializeField] protected float attactDelay;


    protected void Awake() {

        _animator = GetComponent<Animator>();
        
        hp = maxHp;
    }
    public virtual void Ondamage(float damage) {
       
        if (hp > 0)
            hp -= damage;

        if (hp <= 0)
            OnDie();
    }

    protected abstract void OnDie();
}
