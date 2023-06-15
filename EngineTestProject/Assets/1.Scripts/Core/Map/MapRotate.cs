using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MapRotate : MonoBehaviour
{
    [SerializeField] private GameObject _map;

    Quaternion leftRot, rightRot, rot;
    bool isSpinning = false;

    private void Start() {
        
        leftRot = Quaternion.Euler(0, 0, -90f);
        rightRot = rot = Quaternion.Euler(90f, 0, 0);
    }

    private void Update() {
        
        if (!isSpinning) {

            if (Input.GetKeyDown(KeyCode.Q))
                Rotate(leftRot);
            if (Input.GetKeyDown(KeyCode.E))
                Rotate(rightRot);
        }
    }
    
    private void Rotate(Quaternion rot) {

        isSpinning = true;
        _map.transform.DORotateQuaternion(rot * _map.transform.rotation, 0.5f).SetEase(Ease.InOutExpo).OnComplete(() => isSpinning = false);
    }
}