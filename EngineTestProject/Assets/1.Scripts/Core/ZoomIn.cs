using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ZoomIn : MonoBehaviour
{
    [SerializeField] private Camera _cam;
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
        
        if (Input.GetKeyDown(KeyCode.Space)) {

            isZoom = !isZoom;

            if (isZoom) { // zoom true 라면

                DOVirtual.Float(minZoom, maxZoom, 1f, value => {
                    _cam.fieldOfView = value; }).SetEase(ease);

                if (_cam.transform.position.y <= maxHeight)
                    _cam.transform.DOMoveY(maxHeight, 1f).SetEase(ease);
            }
            else {

                DOVirtual.Float(maxZoom, minZoom, 1f, value => {
                    _cam.fieldOfView = value; }).SetEase(ease);

                if (_cam.transform.position.y >= minHeight)
                    _cam.transform.DOMoveY(minHeight, 1f).SetEase(ease);
            }
        }

    }
}
