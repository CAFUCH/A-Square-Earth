using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    NavMeshAgent _agent;

    [SerializeField] private float speed;
    Vector3 pos;

    private void Awake() {
        
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {

        if (Input.GetKeyDown(KeyCode.Mouse0))
            Move();

        if (Input.GetKeyDown(KeyCode.Mouse1))
            Attack();
    }
    
    private void Move() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            pos = hit.point;

        _agent.speed = speed;
        _agent.SetDestination(pos);
    }

    private void Attack() {

        //우클릭으로 받았어
        // 1. 우클릭 한 상대가 엔티티 인가?
        // 2. 엔티티라면 따라가고 일정 거리로 들어오면 액션하기
        // _agent.SetDestination()
    }
}
