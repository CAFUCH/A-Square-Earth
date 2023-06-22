using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject hit;

    [SerializeField] private GameObject attackPos_P, attackPos_E, arrow;
    [SerializeField] private LayerMask layer;
    
    GameObject item;
    public Vector3 dir;    
    Quaternion qua;

    public void Arrow() { // 방향,, 기울기,, 등등,,,
     
        // item = Instantiate(arrow, attackPos_P.transform.position, Quaternion.Euler(90f, 0f, 0f));
        // dir = hit.transform.position - item.transform.position;
        // item.transform.rotation = Quaternion.LookRotation(dir);
        // // item.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        // // item.transform.rotation = transform.rotation;

        Core.instance.AddItem(arrow, attackPos_P);

        dir = hit.transform.position - Core.instance.item.transform.position;
        Core.instance.item.transform.forward = dir.normalized;
        // Core.instance.item.transform.rotation = Quaternion.Euler(90f, 0, 0);
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

        hit.GetComponent<IDamageable>().Ondamage(GetComponent<Enemy>().Damage);
    }

    // private void OnDrawGizmosSelected() {
        
    //     if(UnityEditor.Selection.activeObject == gameObject)
    //     {
    //         Gizmos.color = Color.red;
    //         Gizmos.DrawRay(transform.position, dir);
    //         Gizmos.color = Color.white;
    //     }
    // }
}
