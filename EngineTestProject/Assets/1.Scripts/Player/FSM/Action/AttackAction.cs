using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : PlayerState
{
    Core core;
    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        base.CheckTransition(target, hit);
    }
    
    protected override void Action(RaycastHit hit) {

        Debug.Log("공격 중");

        _animator.SetTrigger("Attack");
    }
}
