using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAction : AIAction
{
    protected override void Awake() {
        
        base.Awake();
    }
    public override void TakeAction() {

        _aiBrain.SetDestinationF(_aiBrain.target.position, speed);

        _animator.SetFloat("Move", speed);
    }
}
