using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController _playerCtrl;
    Camera _cam;
    [SerializeField] private float walkSpeed, runSpeed, jumpForce;
    [SerializeField] private float gravity;
    [SerializeField] private float speed;

    private void Awake() {
        
        _playerCtrl = GetComponent<CharacterController>();
        _cam = GetComponentInChildren<Camera>();
    }

    private void Update() {

        Move();
    }

    private void Move() {

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftShift)) {

            if (speed <= runSpeed)
                speed += Time.deltaTime * 5;
            else
                speed = runSpeed;
        }
        else
            speed = walkSpeed;

        Vector3 dir = new Vector3(x, -gravity, z);
        dir = transform.rotation * dir;
        _playerCtrl.Move(dir * speed * Time.deltaTime);
    }

    // private void Jump() {

    //     float y = 0;

    //     if (_playerCtrl.isGrounded && Input.GetKeyDown(KeyCode.Space))
    //         y = Input.GetAxis("Jump");

    //     Vector3 dir = new Vector3(0, y, 0);

    //     _playerCtrl.Move(dir);

    //     // if (_playerCtrl.isGrounded && Input.GetKeyDown(KeyCode.Space)) {

    //     //     _playerCtrl.Move(Vector3.up * jumpForce * Time.deltaTime);
    //     // }
    // }

    private void Fire() {

        if (Input.GetKeyDown(KeyCode.Mouse0)) {

            Debug.Log("총알 발사");

            // Instantiate()
        }
    }
}
