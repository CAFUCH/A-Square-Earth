using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : Entity
{
    [SerializeField] private GameObject meat;

    protected override void Awake() {

        base.Awake();
    }

    public override void Ondamage(float damage) {

        base.Ondamage(damage);

        _animator.SetTrigger("Hit");
    }

    protected override void OnDie() {

        Destroy(this.gameObject);

        // 고기생성
        _animator.SetTrigger("Die");
        Instantiate(meat, transform.position, Quaternion.identity);
    }
}
