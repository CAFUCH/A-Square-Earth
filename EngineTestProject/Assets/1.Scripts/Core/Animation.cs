using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public RaycastHit hit;

    [SerializeField] private GameObject attackPos_P, attackPos_E, arrow;
    [SerializeField] private LayerMask layer;
    
    GameObject item;
    Vector3 dir;    

    Ray ray;
    RaycastHit rayHit;

    public void Arrow() { // 방향,, 기울기,, 등등,,,
     
        item = Instantiate(arrow, attackPos_P.transform.position, Quaternion.Euler(90f, 0f, 0f));
        dir = hit.point - item.transform.position;
        item.transform.rotation = Quaternion.LookRotation(dir);
        // item.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        // item.transform.rotation = transform.rotation;
    }

    public void PickUp() {
        
        item = hit.transform.gameObject;

        if (item.CompareTag("Meat"))
            UIManager.instance.meatCnt++;
        else if (item.CompareTag("Timber"))
            UIManager.instance.timberCnt++;

        Destroy(item);
    }

    public void EnemyAttack() { // 고장났다.

        if (Physics.SphereCast(attackPos_E.transform.position, 1.5f, Vector3.forward, out rayHit, layer)) {

            Debug.Log(rayHit.collider.name);
            rayHit.collider.GetComponent<IDamageable>().Ondamage(GetComponent<Enemy>().Damage);
        }
    }
}
