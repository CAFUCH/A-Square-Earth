using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleAction_animal : AIAction
{
    protected override void Awake() {

        base.Awake();
    }

    public override void TakeAction() {

        _aiBrain._agent.speed = speed;
        _animator.SetFloat("Move", _aiBrain._agent.speed);
    }
}
