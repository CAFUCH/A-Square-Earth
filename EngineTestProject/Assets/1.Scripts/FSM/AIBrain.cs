using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIBrain : MonoBehaviour
{
    public NavMeshAgent _agent;
    public Enemy _enemy;

    [SerializeField] private AIState _eState; // 현재 상태를 받을 변수
    [SerializeField] private List<AIState> states; // 변경 가능한 상태 리스트
    public Transform target; // 타겟 위치 정보

    private void Awake() {
        
        _agent = GetComponent<NavMeshAgent>();
        _enemy = GetComponent<Enemy>();
        target = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Update() {
        
        foreach (AIState s in states) // 리스트를 모두 검사했을 때
            s.StartTransition(); // 범위 내에 들어왔다면 현재 상태를 변경한다

        _eState?.StartAction(); // 현재 상태의 액션을 실행한다
    }

    public void SetDestinationF(Vector3 pos, float speed) { // 이동하는 함수

        _agent.speed = speed; // 속도를 지정한다
        _agent.SetDestination(pos); // pos로 이동한다
    }

    public void ChangeState(AIState _nextState) { // 현재 상태를 변경하는 함수

        _eState = _nextState; // 매개변수로 받은 상태로 현재 샹태를 변경한다.
    }
}
