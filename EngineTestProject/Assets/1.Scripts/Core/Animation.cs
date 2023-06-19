using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public RaycastHit hit;

    [SerializeField] private GameObject attackPos, arrow;
    
    GameObject item;
    Vector3 dir;    

    public void Arrow() {
     
        item = Instantiate(arrow, attackPos.transform.position, Quaternion.Euler(90f, 0f, 0f));
        dir = hit.point - item.transform.position;
        item.transform.rotation = Quaternion.LookRotation(dir);
        // item.transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        // item.transform.rotation = transform.rotation;
    }

    public void PickUp() { //성공
        
        item = hit.transform.parent.gameObject;
        Destroy(item);
    }
}
