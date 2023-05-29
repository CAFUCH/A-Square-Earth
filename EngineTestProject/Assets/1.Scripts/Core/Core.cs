using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour
{
    static public Core instance;

    private void Awake() {
        
        if (instance)
            Destroy(this);
        else
            instance = this;
    }
    public void OnDamage(float hp, float damage) {

        hp -= damage;

        if (hp <= 0)
            Debug.Log("사망");
    }
}
