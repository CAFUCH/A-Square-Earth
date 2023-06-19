using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Entity
{
    [SerializeField] private GameObject timber; // 목재 item prefabs
    GameObject parent;

    protected override void Awake() {

        base.Awake();
        parent = GetComponentInParent<GameObject>();
    }

    public override void Ondamage(float damage) {
        
        base.Ondamage(damage);
    }

    protected override void OnDie() {

        Debug.Log("나무 사망");

        // 파티클 생성, 파티클이 끝나면 없앤다.
        Destroy(gameObject); //없앤다.

        Vector3 dir = new Vector3(transform.position.x, 0.05f, transform.position.z);
        // 나무 아이템을 생성한다.
        GameObject item = Instantiate(timber, transform.position, Quaternion.identity);

        item.transform.SetParent(parent.transform);
        item.transform.position = dir;
    }
}
