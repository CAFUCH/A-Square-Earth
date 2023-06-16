using System.Reflection;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBrain : MonoBehaviour
{
    public Player player;

    public NavMeshAgent _agent;
    public PlayerState _pState;

    public List<PlayerState> states;

    GameObject target;
    RaycastHit point;

    private void Awake() {
        
        _agent = GetComponent<NavMeshAgent>();
        player = GetComponent<Player>();
    }

    private void Update() {
        
        _pState?.CheckTransition(target, point); //현재 상태의
    }

    public void ClickObj() { //obj가 클릭됐을 때 실행

        Debug.Log("클릭중");

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {

            Debug.Log(hit.collider.name);
            target = hit.collider.gameObject;
            point = hit;

            _agent.speed = player.Speed;

            foreach (PlayerState s in states)
                if (s.CheckLayer(target))
                    _pState = s;
        }
    }
}
