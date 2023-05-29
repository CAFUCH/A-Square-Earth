using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ZoomIn : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private GameObject _map;
    [SerializeField] private Ease ease;

    [SerializeField] float minZoom ,maxZoom;
    [SerializeField] float minHeight, maxHeight;

    bool isZoom = false;
    float dt;

    private void Start() {
        
        // Tweener twn = DOTween.To(() => 
        // minZoom, value => dt = value, maxZoom, 1.5f).SetEase(ease); //문제 있음

        
    }

    private void Update() { //다트윈 쓹
        
        if (Input.GetKeyDown(KeyCode.Mouse1)) {

            isZoom = !isZoom;

            if (isZoom) { // zoom true 라면

                DOVirtual.Float(minZoom, maxZoom, 1f, value => {
                    _cam.fieldOfView = value; }).SetEase(ease);

                if (_map.transform.position.y >= maxHeight)
                    _map.transform.DOMoveY(maxHeight, 1f).SetEase(ease);
            }
            else {

                DOVirtual.Float(maxZoom, minZoom, 1f, value => {
                    _cam.fieldOfView = value; }).SetEase(ease);

                if (_map.transform.position.y <= maxHeight)
                    _map.transform.DOMoveY(minHeight, 1f).SetEase(ease);
            }
        }

    }
}
