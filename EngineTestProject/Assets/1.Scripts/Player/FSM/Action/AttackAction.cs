using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAction : PlayerState
{
    Core core;
    public override bool CheckLayer(GameObject target) {

        return base.CheckLayer(target);
    }

    public override void CheckTransition(GameObject target, RaycastHit hit) {

        base.CheckTransition(target, hit);
    }
    
    protected override void Action(RaycastHit hit) {

        // _pBrain._agent.speed = 0f; // 멈추기

        // hit.collider.gameObject.GetComponent<Tree>().Ondamage(_pBrain.player.damage);

        Debug.Log("공격 중");
    }
}
