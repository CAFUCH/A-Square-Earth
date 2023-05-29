using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBrain : MonoBehaviour
{
    [SerializeField] NavMeshAgent _navAgent;

    [SerializeField] private AIState curAIState; // 현재 상태를 받을 변수
    [SerializeField] private List<AIState> states; // 변경 가능한 상태 리스트
    public Transform target; // 타겟 위치 정보

    private void Awake() {
        
        _navAgent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        
        foreach (AIState a in states) { // 리스트를 모두 검사했을 때

            a.StartTransition(); // 범위 내에 들어왔다면 현재 상태를 변경한다
        }

        curAIState?.StartAction(); // 현재 상태의 액션을 실행한다
    }

    public void SetDestinationF(Vector3 pos, float speed) { // 이동하는 함수

        _navAgent.speed = speed; // 속도를 지정한다
        _navAgent.SetDestination(pos); // pos로 이동한다
    }

    public void ChangeState(AIState _nextState) { // 현재 상태를 변경하는 함수

        curAIState = _nextState; // 매개변수로 받은 상태로 현재 샹태를 변경한다.
    }
}
