using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitAction : PlayerState
{
    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        base.CheckTransition(target, hit);
    }

    protected override void Action(RaycastHit hit) {

        _animator.SetTrigger("Felling");

        _pBrain._pState = null;

        if (hit.collider.TryGetComponent<IDamageable>(out IDamageable target))
            target.Ondamage(1f);
    }
}
