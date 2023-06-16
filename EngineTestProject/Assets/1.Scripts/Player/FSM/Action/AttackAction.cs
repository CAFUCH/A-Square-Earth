using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : PlayerState
{
    Core core;
    IDamageable target;
    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        base.CheckTransition(target, hit);
    }
    
    protected override void Action(RaycastHit hit) {

        Debug.Log("공격 중");

        _pBrain._agent.speed = 0;

        // _animator.SetTrigger("Attack");
        _animator.SetTrigger("PickUp");

        // 데미지 주기,,
        _pBrain._pState = null;
        
        if (hit.collider.gameObject.TryGetComponent<IDamageable>(out target))
            target.Ondamage(_pBrain.player.Damage);
    }
}
