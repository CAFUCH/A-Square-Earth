using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerState : MonoBehaviour
{
    protected PlayerBrain _pBrain;

    [SerializeField] protected LayerMask StateLayer;
    [SerializeField] protected float StateDist;

    protected float distance;

    private void Awake() {
        
        _pBrain = GetComponentInParent<PlayerBrain>();
    }

    public virtual bool CheckLayer(GameObject target) { // 레이어 검사를 통해 알맞은 action 찾기

        // Debug.Log(((1 << target.layer & StateLayer) != 0) + " " + this.name);
        return (1 << target.layer & StateLayer) != 0;
    }

    public virtual void CheckTransition(GameObject target, RaycastHit hit) {

        float distance = Vector3.Distance(transform.position, target.transform.position); // 거리 측정

        if (distance <= StateDist) // 거리 검사
            Action(hit);
        else
            _pBrain._agent.SetDestination(target.transform.position);
    }

    protected abstract void Action(RaycastHit hit);
    
    private void OnDrawGizmos() { // 눈에 보이게 그려주자!

        if(UnityEditor.Selection.activeObject == gameObject)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, StateDist);
            Gizmos.color = Color.white;
        }
    }
}
