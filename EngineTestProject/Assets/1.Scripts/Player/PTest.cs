using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTest : MonoBehaviour {
    PlayerBrain _brain;

    private void Awake() {
        
        _brain = GetComponent<PlayerBrain>();
    }

    private void Update() {

        if (Input.GetKeyDown(KeyCode.Mouse1))
            _brain.ClickObj();
    }
}
