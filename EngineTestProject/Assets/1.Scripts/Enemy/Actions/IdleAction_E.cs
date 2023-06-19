using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAction_E : AIAction
{
    protected override void Awake() {
        
        base.Awake();
    }
    public override void TakeAction() {

        // aiBrain.SetDestinationF(aiBrain.target.position, 0f);
        Debug.Log("에잇 공격");

        _animator.SetFloat("Move", speed);
    }
}
