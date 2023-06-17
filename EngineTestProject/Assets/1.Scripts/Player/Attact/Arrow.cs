using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // 화살 자체의 스크립트?

    // 생성할 때 부터 방향을 조절해줘서 여기선 그냥 forward로 날아가게?

    private Rigidbody _rigid;
    [SerializeField] private float speed;

    private void Awake() {
        
        _rigid = GetComponent<Rigidbody>();
    }

    private void Update() {
        
        _rigid.velocity = transform.forward * speed;
    }
}
