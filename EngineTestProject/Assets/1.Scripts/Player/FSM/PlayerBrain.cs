using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerBrain : MonoBehaviour
{
    // 입력을 받고 state들을 검사하면 옳은 state를 실행하는

    public NavMeshAgent _agent;

    public PlayerState _pState;

    GameObject target;

    public PlayerState folowingState, attackState;

    private void Update() {
        
        _pState?.TakeAction(target);
    }

    public void ClickObj(RaycastHit hit) { //obj가 클릭됐을 때 실행

        // if (Input.GetKeyDown(KeyCode.Mouse1)) {

            // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // RaycastHit hit;

            // if (Physics.Raycast(ray, out hit)) {

            //     target = hit.collider.gameObject;
            // }
        // }

        target = hit.collider.gameObject; //target 저장하고

        _pState = folowingState;

    }

    public void ChangeState(PlayerState nextState) {

        _pState = nextState;
    }
}
