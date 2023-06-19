using System.Reflection;
using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBrain : MonoBehaviour
{
    public Player _player;

    public NavMeshAgent _agent;
    public PlayerState _pState;

    public List<PlayerState> states;

    GameObject target;
    RaycastHit point;

    private void Awake() {
        
        _agent = GetComponent<NavMeshAgent>();
        _player = GetComponent<Player>();
    }

    private void Update() {
        
        _pState?.CheckTransition(target, point); //현재 상태의
    }

    public void ClickObj(RaycastHit hit) { //obj가 클릭됐을 때 실행

            Debug.Log(hit.collider.name + " " + hit.collider.gameObject.GetComponentInParent<Transform>().rotation);
        target = hit.collider.gameObject;
        point = hit;

        _agent.speed = _player.Speed;

        foreach (PlayerState s in states)
            if (s.CheckLayer(target))
                _pState = s;
    }
}
