using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceDecision : AIDecision
{
    AIBrain aiBrain;
    [SerializeField] private float distance; //특정 상태의 거리

    private void Awake() {
        
        aiBrain = GetComponentInParent<AIBrain>();
    }
    public override bool MakeDecition() {

        return Vector3.Distance(aiBrain.target.position, transform.position) < distance; // 타겟이 거리 안으로 들어왔다면 true 반환
    }

    private void OnDrawGizmos() { // 눈에 보이게 그려주자!

        if(UnityEditor.Selection.activeObject == gameObject)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, distance);
            Gizmos.color = Color.white;
        }
    }
}
