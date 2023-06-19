using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction_E : AIAction
{
    bool canAttack = true;

    public override void TakeAction() {

        if (canAttack) {

            _animation.hit = _aiBrain.target.gameObject;
            _animator.SetTrigger("Attack");

            StartCoroutine(delay());
        }
    }

    IEnumerator delay() {

        canAttack = false;
        yield return new WaitForSeconds(_aiBrain._enemy.AttackDelay);
        canAttack = true;
    }
}
