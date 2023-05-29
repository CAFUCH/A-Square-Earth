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
        float dt;

        private void Start() {
            
            
        }

        private void Update() { //다트윈 쓹
            
            if (Input.GetKeyDown(KeyCode.Mouse1)) {

                Debug.Log("click");

                // Tweener twn = DOTween.To(() => 
                // minZoom, value => dt = value, maxZoom, 1.5f).SetEase(ease); //문제 있음

                // if (_cam.fieldOfView >= maxZoom)
                //     _cam.fieldOfView = _cam.transform.DOMoveX

                if (_map.transform.position.y >= maxHeight)
                    _map.transform.DOMoveY(maxHeight, 1.5f).SetEase(ease);
            }
        }
    }
