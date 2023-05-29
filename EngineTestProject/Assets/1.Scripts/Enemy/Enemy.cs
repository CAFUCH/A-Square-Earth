using System.Xml.Serialization;
using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    private void Awake() {
        
        hp = maxHp;
    }
    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("Player")) {

            Core.instance.OnDamage(hp, damage);
        }
    }
}
