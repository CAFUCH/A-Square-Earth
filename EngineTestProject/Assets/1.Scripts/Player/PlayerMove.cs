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

        if (Input.GetKeyDown(KeyCode.Mouse0)) {

            Move();
        }
    }
    
    private void Move() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
            pos = hit.point;

        _agent.speed = speed;
        _agent.SetDestination(pos);
    }
}
