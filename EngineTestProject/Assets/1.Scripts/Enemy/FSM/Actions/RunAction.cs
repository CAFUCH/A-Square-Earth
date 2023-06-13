using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAction : AIAction
{
    protected override void Awake() {
        
        base.Awake();
    }
    public override void TakeAction() {

        aiBrain.SetDestinationF(aiBrain.target.position, speed);

        _animator.SetFloat("Move", speed);
    }
}
