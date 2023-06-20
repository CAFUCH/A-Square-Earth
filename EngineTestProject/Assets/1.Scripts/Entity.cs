using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour, IDamageable
{
    protected Animator _animator;

    [SerializeField] protected float hp, maxHp;
    public float Hp { get { return hp; } set { hp = value; } }
    public float MaxHp { get { return maxHp; } }
    [SerializeField] protected float eng, maxEng;
    public float Eng { get { return eng; } set { eng = value; } }
    public float MaxEng { get { return maxEng; } }
    [SerializeField] protected float speed;
    public float Speed { get { return speed; } }
    [SerializeField] protected float damage;
    public float Damage { get { return damage; } }
    [SerializeField] protected float attactDelay;
    public float AttackDelay { get { return attactDelay; } }


    protected virtual void Awake() {

        _animator = GetComponent<Animator>();
        
        hp = maxHp;
        eng = maxEng;
    }
    public virtual void Ondamage(float damage) {
       
        if (hp > 0)
            hp -= damage;

        if (hp <= 0)
            OnDie();
    }

    protected abstract void OnDie();
}
