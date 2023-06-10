using System.Net.Http.Headers;
using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerBrain _pBrain;
    private void Awake() {
        
        _pBrain = GetComponent<PlayerBrain>();
    }

    private void Update() {

        if (Input.GetKeyDown(KeyCode.Mouse1))
            _pBrain.ClickObj();
    }
}
