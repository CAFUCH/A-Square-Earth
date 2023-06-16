using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpAction : PlayerState
{
        public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {
        
        base.CheckTransition(target, hit);
    }

    protected override void Action(RaycastHit hit) {

        Debug.Log("줍는 중");

        _pBrain._agent.speed = 0;

        // 애니메이션 (attack과 같이 damagecaster 사용,,)x`S
        _animation.hit = hit;
        _animator.SetTrigger("PickUp");

        _pBrain._pState = null;
        
    }
}
