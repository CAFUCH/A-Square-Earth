using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    [SerializeField] private GameObject OverP;
    // private void OnCollisionEnter(Collision other) {
        
    //     if (other.gameObject.CompareTag("Enemy")) {

    //         // Core.instance.OnDamage(hp, damage);
    //     }
    // }
    private void Update() {
        
        if (0 < eng)
            eng -= Time.deltaTime;
        else {

            hp -= 5f;
        }
    }

    public override void Ondamage(float damage)
    {
        base.Ondamage(damage);

        // 다른 entity와 다르게 플레이어가 공격했을 때만 실행되는 것들
    }
    protected override void OnDie() {
        
        _animator.SetTrigger("Die");

        OverP.SetActive(true);

        // 다른 entity와 다르게 플레이어가 사망했을 때만 실행되는 것들
    }
}
