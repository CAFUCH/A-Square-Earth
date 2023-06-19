using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    // private void OnCollisionEnter(Collision other) {
        
    //     if (other.gameObject.CompareTag("Enemy")) {

    //         // Core.instance.OnDamage(hp, damage);
    //     }
    // }

    public override void Ondamage(float damage)
    {
        base.Ondamage(damage);

        // 다른 entity와 다르게 플레이어가 공격했을 때만 실행되는 것들
    }
    protected override void OnDie() {
        
        Debug.Log("게임오버");

        _animator.SetTrigger("Die");

        // 다른 entity와 다르게 플레이어가 사망했을 때만 실행되는 것들
    }
}
