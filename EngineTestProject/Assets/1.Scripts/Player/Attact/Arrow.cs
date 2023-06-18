using System.Xml.Serialization;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // 화살 자체의 스크립트?

    // 생성할 때 부터 방향을 조절해줘서 여기선 그냥 forward로 날아가게?

    private Player _player;
    private Rigidbody _rigid;
    [SerializeField] private float speed;
    [SerializeField] private LayerMask layer;

    private void Awake() {
        
        _rigid = GetComponent<Rigidbody>();
    }

    private void Update() {
        
        _player = GameObject.Find("Player").GetComponent<Player>();
        _rigid.velocity = transform.forward * speed;
    }

    private void OnTriggerEnter(Collider other) {
        
        if ((1 << other.gameObject.layer & layer) != 0) {

            Destroy(this.gameObject); // 화살 삭제
            other.GetComponent<IDamageable>().Ondamage(_player.Damage);
        }
    }
}
