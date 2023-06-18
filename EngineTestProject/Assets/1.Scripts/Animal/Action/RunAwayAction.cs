using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAwayAction : AIAction
{
    Vector3 dir;
    protected override void Awake() {

        base.Awake();
    }

    public override void TakeAction() {

        dir = transform.position - _aiBrain.target.transform.position;
        _aiBrain.SetDestinationF(transform.position + dir, speed);
        transform.rotation = Quaternion.LookRotation(dir);

        _animator.SetFloat("Move", _aiBrain._agent.speed);
    }
}
