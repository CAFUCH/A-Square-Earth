using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public RaycastHit hit;
    public void Arrow() {

        Debug.Log("화살 뾱");
        
        // 화살을 생성한다.
        // 생성한 뒤 방향을 조절한다 (hit으로)
    }

    public void PickUp() { //성공
        
        Destroy(hit.collider.gameObject);
    }
}
