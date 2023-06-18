using System.Xml.Serialization;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    bool isDie = false;

    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("Player")) {

            // Core.instance.OnDamage(hp, damage);
        }
    }

    public override void Ondamage(float damage) {

        base.Ondamage(damage);
    }

    protected override void OnDie() {
        
        isDie = true;

        _animator.SetTrigger("Die");

        Destroy(gameObject);
    }
}
