using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour, IDamageable
{
    protected Animator _animator;

    [SerializeField] protected float hp, maxHp;
    [SerializeField] protected float speed;
    public float Speed { get { return speed; } }
    [SerializeField] protected float damage;
    public float Damage { get { return damage; } }
    [SerializeField] protected float attactDelay;


    protected virtual void Awake() {

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
