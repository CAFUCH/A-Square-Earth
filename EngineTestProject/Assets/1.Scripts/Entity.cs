using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour, IDamageable
{
    [SerializeField] protected float hp, maxHp;
    [SerializeField] protected float walkSpeed, runSpeed;
    [SerializeField] protected float damage;
    [SerializeField] protected float attactDelay;


    protected void Awake() {
        
        hp = maxHp;
    }
    public void Ondamage(float damage) {
       
        hp -= damage;

        if (hp <= 0)
            OnDie();
    }

    protected abstract void OnDie();
}
