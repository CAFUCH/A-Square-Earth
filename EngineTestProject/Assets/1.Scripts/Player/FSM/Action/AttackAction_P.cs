using System.Security.Cryptography;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction_P : PlayerState
{
    Core core;
    IDamageable target;

    Vector3 dir;
    bool canAttack = true;

    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        base.CheckTransition(target, hit);
    }
    
    protected override void Action(RaycastHit hit) {
        
        if (canAttack) {

            dir = hit.transform.position - _pBrain.transform.position;
            _pBrain.transform.rotation = Quaternion.LookRotation(dir);

            _animation.hit = hit.collider.gameObject;
            _animator.SetTrigger("Attack");

            _pBrain._pState = null;
        }
    }

    IEnumerator delay() {

        canAttack = false;
        yield return new WaitForSeconds(_pBrain._player.AttackDelay);
        canAttack = true;
    }
}
