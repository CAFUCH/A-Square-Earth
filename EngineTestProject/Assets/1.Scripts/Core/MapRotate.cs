using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapRotate : MonoBehaviour
{
    [SerializeField] private GameObject _map;

    [SerializeField] int leftCount, rightCount = 0;

    Quaternion rot;
    Vector3 dir;

    private Vector3[] leftDir = new Vector3[] {

        new Vector3(15f, -15f, 0f),
        new Vector3(-15f, -15f, 0f),
        new Vector3(-15f, 15f, 0f),
        new Vector3(15f, 15f, 0f)
    };

    private Vector3[] rightDir = new Vector3[] {

        new Vector3(0f, -15f, 15f),
        new Vector3(0f, -15f, -15f),
        new Vector3(0f, 15f, -15f),
        new Vector3(0f, 15f, 15f)
    };

    private void Update() {
        
        if (Input.GetKeyDown(KeyCode.E))
            RightMap();
        if (Input.GetKeyDown(KeyCode.Q))
            LeftMap();
    }

    public void LeftMap() {

        rot = Quaternion.Euler(0, 0, -90f);
        _map.transform.rotation *= rot;

        dir = leftDir[leftCount % leftDir.Length];
        _map.transform.position += dir;

        leftCount++;
    }

    public void RightMap() {

        rot = Quaternion.Euler(90f, 0, 0);
        _map.transform.rotation *= rot;

        dir = rightDir[rightCount % rightDir.Length];
        _map.transform.position += dir;

        rightCount++;
    }
}
