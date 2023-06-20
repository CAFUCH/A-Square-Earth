// using System.Collections.Immutable;
// using System;
// using System.Runtime.InteropServices;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Timer : MonoBehaviour
// {
//     public static Timer instance;
    
//     public bool isToday = false;
//     public float time;
//     [SerializeField] private float maxTime;

//     private void Awake() {
        
//         if (instance == null)
//             instance = this;
//         else
//             Destroy(instance);  
//     }

//     private void Update() {
        
//         if (time > 0f && !isToday)
//             time -= Time.deltaTime;
//         else {

//             isToday = true;
//             time = maxTime;
//         }
//     }
// }
