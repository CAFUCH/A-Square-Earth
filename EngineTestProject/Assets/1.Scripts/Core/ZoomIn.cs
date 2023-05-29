using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomIn : MonoBehaviour
{
   [SerializeField] private Camera _cam;
   [SerializeField] private GameObject _map;

   [SerializeField] float minZoom ,maxZoom;
   [SerializeField] float minHeight, maxHeight;

    private void Update() { //다트윈 쓹
        
        // if (Input.GetKeyDown(KeyCode.Mouse1)) {

        //     if (_cam.fieldOfView <= maxZoom)
        //         _cam.fieldOfView += Time.deltaTime;
        //     if (_map.transform.position.y <= maxHeight)
        // }
    }
}
