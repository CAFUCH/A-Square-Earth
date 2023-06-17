using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public RaycastHit hit;

    [SerializeField] private GameObject attackPos, arrow;
    
    GameObject item;
    Quaternion qua = Quaternion.Euler(0, 90, 0);

    public void Arrow() {

        Debug.Log("화살 뾱");
        
        // 화살을 생성한다.
        // 생성한 뒤 방향을 조절한다 (hit으로)

        item = Instantiate(arrow, attackPos.transform.position, Quaternion.identity);
        item.transform.rotation = qua;

    }

    public void PickUp() { //성공
        
        item = hit.transform.parent.gameObject;
        Destroy(item);
    }
}
