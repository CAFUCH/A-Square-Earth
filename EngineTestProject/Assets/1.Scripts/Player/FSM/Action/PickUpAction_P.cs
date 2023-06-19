using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAction_P : PlayerState
{
        public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {
        
        base.CheckTransition(target, hit);
    }

    protected override void Action(RaycastHit hit) {

        _pBrain._agent.speed = 0;

        _animation.hit = hit.collider.gameObject;
        _animator.SetTrigger("PickUp");

        _pBrain._pState = null;
        
    }
}
