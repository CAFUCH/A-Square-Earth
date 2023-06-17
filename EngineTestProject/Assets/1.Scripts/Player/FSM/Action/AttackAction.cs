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

        _animator.SetTrigger("Attack");

        // 데미지 주기,,
        // if (hit.collider.gameObject.TryGetComponent<IDamageable>(out target))
        //     target.Ondamage(_pBrain.player.Damage);

        // 화살 발

        _pBrain._pState = null;
    }
}
