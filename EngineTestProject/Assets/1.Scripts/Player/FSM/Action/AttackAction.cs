using System.Security.Cryptography;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : PlayerState
{
    Core core;
    IDamageable target;

    Vector3 dir;

    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        base.CheckTransition(target, hit);
    }
    
    protected override void Action(RaycastHit hit) {
        
        dir = hit.transform.position - _pBrain.transform.position;
        _pBrain.transform.rotation = Quaternion.LookRotation(dir);

        _animator.SetTrigger("Attack");

        _pBrain._pState = null;
    }
}
