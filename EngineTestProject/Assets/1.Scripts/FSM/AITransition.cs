using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITransition : MonoBehaviour
{
    public AIState nextState;

    private AIDecision decision;

    private void Awake() {
        
        nextState = GetComponent<AIState>();
        decision = GetComponent<AIDecision>();
    }

    public bool CheckTransition() { // 특정 상태로 변경할 수 있는지 확인하는 함수

        bool result = false;

        return result = decision.MakeDecition(); // 거리 안으로 들어왔다면 true 반환
    }
}
