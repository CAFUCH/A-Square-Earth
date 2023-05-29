using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private void Awake() {
        
        hp = maxHp;
    }
    
    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("Enemy")) {

            Core.instance.OnDamage(hp, damage);
        }
    }
}
