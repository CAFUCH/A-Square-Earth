using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected float hp, maxHp;
    [SerializeField] protected float walkSpeed, runSpeed;
    [SerializeField] protected float damage;
    [SerializeField] protected float attactDelay;
}
