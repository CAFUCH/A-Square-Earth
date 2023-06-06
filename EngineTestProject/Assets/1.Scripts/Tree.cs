using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Entity
{
    [SerializeField] private GameObject timber; // 목재 item prefabs

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.Y))
            Core.instance.OnDamage(hp, 1f);
    }
    protected override void OnDie() {

        Debug.Log("나무 사망");

        // 파티클 생성, 파티클이 끝나면 없앤다.
        Destroy(gameObject, 1f); // 없앤다.
        // 나무 아이템을 생성한다.
        Instantiate(timber, transform.position, Quaternion.identity);
    }
}
