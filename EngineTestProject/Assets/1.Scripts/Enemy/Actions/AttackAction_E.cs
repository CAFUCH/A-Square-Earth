using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction_E : AIAction
{
    public override void TakeAction() {

        _animator.SetTrigger("Attack");
    }
}
