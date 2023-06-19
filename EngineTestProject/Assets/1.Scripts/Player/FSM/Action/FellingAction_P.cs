using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FellingAction_P : PlayerState
{
    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        base.CheckTransition(target, hit);
    }

    protected override void Action(RaycastHit hit) {

        _pBrain._agent.speed = 0;

        _animator.SetTrigger("Felling");

        _pBrain._pState = null;

        if (hit.collider.TryGetComponent<IDamageable>(out IDamageable target))
            target.Ondamage(1f);
    }
}
