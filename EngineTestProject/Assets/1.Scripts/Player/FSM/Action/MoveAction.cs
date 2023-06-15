using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAction : PlayerState
{
    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        Action(hit);
    }

    protected override void Action(RaycastHit hit) {


        _pBrain._agent.SetDestination(hit.point);

        if (0.1f > Vector3.Distance(_pBrain.player.transform.position, hit.point))
            _pBrain._agent.speed = 0;

        _animator.SetFloat("Move", _pBrain._agent.speed);
    }
}
