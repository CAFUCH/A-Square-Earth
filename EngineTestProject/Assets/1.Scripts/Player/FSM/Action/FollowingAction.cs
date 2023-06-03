using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingAction : PlayerState
{
    public override void TakeAction(GameObject target) {

        // base.TakeAction();

        distance = Vector3.Distance(transform.position, target.transform.position);

        if (attackDist <= distance)
            _pBrain.ChangeState(_pBrain.attackState);
        else 
            _pBrain._agent.SetDestination(target.transform.position);
    }
}
