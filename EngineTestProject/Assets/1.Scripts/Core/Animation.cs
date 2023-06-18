using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public RaycastHit hit;

    [SerializeField] private GameObject attackPos, arrow;
    
    GameObject item;
    
    public void Arrow() {
     
        item = Instantiate(arrow, attackPos.transform.position, Quaternion.identity);
        item.transform.rotation = transform.rotation;
    }

    public void PickUp() { //성공
        
        item = hit.transform.parent.gameObject;
        Destroy(item);
    }
}
