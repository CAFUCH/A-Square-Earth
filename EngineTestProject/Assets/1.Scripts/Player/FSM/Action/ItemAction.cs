using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAction : PlayerState
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

        // 애니메이션
        
        Destroy(hit.collider.gameObject);

        _pBrain._pState = null;
    }
}
