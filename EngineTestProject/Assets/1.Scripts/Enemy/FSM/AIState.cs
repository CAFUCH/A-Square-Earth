using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIState : MonoBehaviour
{
    AIBrain _aiBrain;
    [SerializeField] private AIAction action; // 특정 상태의 액션
    [SerializeField] private AITransition transition; // 특정 상태의 변경사항

    private void Awake() {
        
        _aiBrain = GetComponentInParent<AIBrain>();
    }

    public void StartTransition() {

        if (transition.CheckTransition()) // 특정 상태로 변경할 수 있는가
            _aiBrain.ChangeState(transition.nextState); // 특정 상태로 변경한다
    }

    public void StartAction() {

        action.TakeAction(); // 특정 상태의 액션을 실행한다
    }
}
