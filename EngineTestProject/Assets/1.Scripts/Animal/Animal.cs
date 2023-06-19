using Microsoft.Win32.SafeHandles;
using System.Xml.Serialization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Animal : Entity
{
    [SerializeField] private GameObject meat;
    [SerializeField] private GameObject parent;
    GameObject item;
    Vector3 dir;

    protected override void Awake() {

        base.Awake();
    }

    public override void Ondamage(float damage) {

        base.Ondamage(damage);

        _animator.SetTrigger("Hit");
    }

    protected override void OnDie() {

        _animator.SetTrigger("Die");

        Destroy(this.gameObject);

        Core.instance.AddItem(meat, this.gameObject);
    }
}
