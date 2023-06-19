using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : Entity
{
    [SerializeField] private GameObject timber1, timber2; // 목재 item prefabs
    GameObject parent;

    protected override void Awake() {

        base.Awake();
        parent = GetComponentInParent<GameObject>();
    }

    public override void Ondamage(float damage) {
        
        base.Ondamage(damage);
    }

    protected override void OnDie() {

        Destroy(this.gameObject);

        if (gameObject.CompareTag("SmallTree"))
            Core.instance.AddItem(timber1, this.gameObject);
        else if (gameObject.CompareTag("BigTree"))
            Core.instance.AddItem(timber2, this.gameObject);
    }
}
