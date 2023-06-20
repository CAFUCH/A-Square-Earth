using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCaster : MonoBehaviour
{
    [SerializeField] private LayerMask objLayer;
    [SerializeField] private float castRadius;

    float damage; //현재 엔티티의 데미지를 찾아와야함

    private void Awake() {
        
        // damage = GetComponent<
    }

    private void Update() {
        
        DamageCast();
    }

    public void DamageCast() {

        RaycastHit hit;
    
        bool isHit = Physics.SphereCast(transform.position - transform.forward * castRadius,
            castRadius, transform.forward, out hit, castRadius, objLayer);

        if (isHit) {

            Debug.Log(hit.collider.name);
            if (hit.collider.TryGetComponent<IDamageable>(out IDamageable target))
                target.Ondamage(damage);
        }
    }

    // private void OnDrawGizmos() { // 눈에 보이게 그려주자!

    //     if(UnityEditor.Selection.activeObject == gameObject)
    //     {
    //         Gizmos.color = Color.yellow;
    //         Gizmos.DrawWireSphere(transform.position, castRadius);
    //         Gizmos.color = Color.white;
    //     }
    // }
}
