using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("Enemy")) {

            Core.instance.OnDamage(hp, damage);
        }
    }

    protected override void OnDie() {
        
        Debug.Log("게임오버");
    }
}
