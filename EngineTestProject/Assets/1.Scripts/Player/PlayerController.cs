using System.Net.Http.Headers;
using System.IO;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    CharacterController _playerCtrl;
    Camera _cam;
    [SerializeField] private float walkSpeed, runSpeed, rotSpeed, jumpForce;
    [SerializeField] private float gravity;
    [SerializeField] private float speed;

    private void Awake() {
        
        _playerCtrl = GetComponent<CharacterController>();
        _cam = GetComponentInChildren<Camera>();
    }

    private void Update() {

        // Move();
        // Rotate();
        // Attack();
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

        // Vector3 dir = new Vector3(x, -gravity, z);
        // dir = transform.rotation * dir;
        // _playerCtrl.Move(dir * speed * Time.deltaTime);

        Vector3 dir = new Vector3(x, 0, z);
        dir = transform.TransformDirection(dir);
        dir.Normalize();
        _playerCtrl.Move(dir * speed * Time.deltaTime);
    }

    private void Rotate() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {
            
            Vector3 target = hit.point;

            Vector3 dir = target - transform.position;
            dir.y = 0;
            dir.Normalize();

            if (dir != Vector3.zero) {

                Quaternion rot = Quaternion.LookRotation(dir);
                transform.rotation = rot;
            }
        }

        // Vector3 mousePosition = Input.mousePosition;

        // // 마우스 커서 위치에서 화면 방향으로 레이를 쏩니다.
        // Ray ray = Camera.main.ScreenPointToRay(mousePosition);

        // // 레이를 특정 거리만큼 발사하여 월드 좌표를 계산합니다.
        // Vector3 targetPosition = ray.GetPoint(100f);

        // // 플레이어의 위치와 목표 위치 사이의 방향을 구합니다.
        // Vector3 lookDirection = targetPosition - transform.position;
        // lookDirection.y = 0f;

        // // 플레이어의 forward 방향을 바꿉니다.
        // if (lookDirection != Vector3.zero)
        // {
        //     Quaternion rotation = Quaternion.LookRotation(-lookDirection);
        //     transform.rotation = rotation;
        // }
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

    private void Attack() {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit)) {

            Debug.Log(hit.collider.name);
        }
    }
}
