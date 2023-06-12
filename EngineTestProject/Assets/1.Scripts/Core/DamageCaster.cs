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
    public void DamageCast() { // 개발중

        // RaycastHit hit;
    
        // bool isHit = Physics.SphereCast(transform.position, castRadius);

        // if (isHit) {

        //     Debug.Log(hit.collider.name);
        //     if (hit.collider.TryGetComponent<IDamageable>(out IDamageable target))
        //         target.Ondamage(damage);
        // }
    }
}
