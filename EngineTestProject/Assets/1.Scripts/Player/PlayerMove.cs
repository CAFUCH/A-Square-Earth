using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
//     NavMeshAgent _agent;

//     [SerializeField] private float speed;
//     [SerializeField] private LayerMask entityLayer, objLayer;
//     [SerializeField] float longDist, shortDist;

//     Vector3 pos;
//     GameObject target;
//     float distance;
//     bool isFollowing = false;

    PlayerBrain _pBrain;

    private void Awake() {
        
        // _agent = GetComponent<NavMeshAgent>();

        _pBrain = GetComponent<PlayerBrain>();
    }

    private void Update() {

        if (Input.GetKeyDown(KeyCode.Mouse1))
            _pBrain.ClickObj();
    }
    
    // private void Move(RaycastHit hit) {

    //     pos = hit.point;
    //     _agent.speed = speed;
    //     _agent.SetDestination(pos);
    // }

    // private void Attack() {

    //     //우클릭으로 받았어
    //     // 1. 우클릭 한 상대가 엔티티 인가?
    //     // 2. 엔티티라면 따라가고 일정 거리로 들어오면 액션하기
    //     // _agent.SetDestination()

    //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //     RaycastHit hit;

    //     if (Physics.Raycast(ray, out hit)) {

    //         Debug.Log(hit.collider.name);
    //     }
    // }

    // private void test() {

    //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

    //     RaycastHit hit;

    //     if (Physics.Raycast(ray, out hit)) {
            
    //         target = hit.collider.gameObject;

    //         if (hit.collider.gameObject.layer == entityLayer) {

    //             isFollowing = true;
    //         }
    //         else if (hit.collider.gameObject.layer == objLayer) {

    //             isFollowing = true;
    //         }
    //         else //Ground
    //             Move(hit);
    //     }

    //     if (isFollowing) {

    //         distance = Vector3.Distance(transform.position, target.transform.position);

    //         if (shortDist <= distance) { //공격 거리라면

    //             Debug.Log("공격");
    //         }
    //         else if (shortDist >= distance && longDist <= distance) { //거리가..

    //             Debug.Log("원거리 공격");
    //         }
    //         else
    //             Move(hit);
    //     }

    //     //ray로 현재 obj 받고 obj나 entity라면 거리가 되는지 확인하고 거리가 멀다면 이동, 거리가 된다면 공격 또는 상호작용
    //     //그냥 땅이라면 클릭 지점으로 이동
    // }
}
